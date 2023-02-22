using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

namespace Ado11_1
{
    internal class TeachersDbContext: IDisposable
    {
        private IDbConnection dbConnection;
        public TeachersDbContext(string connectionString) 
        {
            dbConnection = new SqlConnection(connectionString); 
            dbConnection.Open();
        }
        public TeachersDbContext() : this(System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString) { }

        public void Dispose()
        {
            dbConnection?.Close();
        }
        
        public void PrintAllTeachers()
        {
            Console.WriteLine("\nPrint All Teachers");
            // получение динамических объектов
            var teachers = dbConnection.Query("select * from Teachers");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.Firstname} {t.Lastname} ({t.Birthdate}) - {t.Department}");
            }
        }

        public void PrintTeacherById(int id)
        {
            Console.WriteLine("\nPrint Teacher by Id");
            // получение динамических объектов
            var teachers = dbConnection.Query("select * from Teachers where Id = @id", new { id });
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.Firstname} {t.Lastname} ({t.Birthdate}) - {t.Department}");
            }
        }

        public void PrintTeacherByName(string fName, string lName)
        {
            Console.WriteLine("\nPrint Teacher by name");
            // получение динамических объектов
            var teachers = dbConnection.Query(
                "select * from Teachers where (Firstname = @firstName and Lastname = @lastName)"
                , new { firstName = fName, lastName = lName });

            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.Firstname} {t.Lastname} ({t.Birthdate}) - {t.Department}");
            }
        }

        public void PrintAllTeachersTypicaly()
        {
            Console.WriteLine("\nPrint All Teachers (typicaly)");

            // получении типизированного результата из БД
            var teachers = dbConnection.Query<Teacher>("select * from Teachers");

            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.Firstname} {t.Lastname} ({t.Birthdate.ToShortDateString()}) - {t.DepartmentId}");
            }
        }

        public void PrintAllTeachersAndDepartments()
        {
            Console.WriteLine("\nPrint All Teachers on Department (typicaly)");

            // получении типизированного результата из БД
            var teachers = dbConnection.Query<Teacher, Department, Teacher>(
                "select * from Teachers as T join Departments as D on D.Id = T.DepartmentId"
                , (t, d) =>
                {
                    t.Department = d;
                    return t;
                });

            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.Firstname} {t.Lastname} - {t.Department.Name}, {t.Department.Phone}");
            }
        }

        public void AddNewGroup()
        {
            // получить ввод от пользователя
            Console.Write("Enter group name = ");
            string groupName = Console.ReadLine();
            Console.Write("Enter facultyId = ");
            int id = int.Parse(Console.ReadLine());

            // добавить группу, используя хранимую процедуру
            // заполняем список параметров
            var p = new DynamicParameters();
            // входные параметры для процедуры
            p.Add("@groupName", groupName);
            p.Add("@faculty", id, DbType.Int32);
            // выходной параметр, возвращает Id добавленной группы
            p.Add("@groupId", DbType.Int32, direction: ParameterDirection.Output);
            // выходной параметр - результат хранимой процедуры
            p.Add("@result", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            // выполняем запрос к БД
            dbConnection.Execute("AddNewGroup", p, commandType: CommandType.StoredProcedure);
            Console.WriteLine($"New Gruop id = {p.Get<int>("@groupId")}");

            // вывести список групп
            Console.WriteLine("\nAll Groups");
            var groups = dbConnection.Query("select * from Groups");
            foreach (var g in groups)
            {
                Console.WriteLine(g);
            }
        }
    }
}
