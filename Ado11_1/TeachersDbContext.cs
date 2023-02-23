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

        public void PrintDepartmentAndTeachers()
        {
            var lookup = new Dictionary<int, Department>();
            dbConnection.Query<Department, Teacher, Department>(
                "select * from Departments as D " +
                "join Teachers as T on D.Id = T.DepartmentId"
                , (d, t) =>
                {
                    Department? department;
                    if (!lookup.TryGetValue(d.Id, out department))
                    {
                        lookup.Add(d.Id, department = d);
                    }
                    if (department.Teachers == null)
                    {
                        department.Teachers = new List<Teacher>();
                    }
                    department.Teachers.Add(t);
                    return department;
                }).AsQueryable();

            foreach (Department department in lookup.Values)
            {
                Console.WriteLine($"Department = {department.Name}, {department.Phone}");
                if (department.Teachers != null)
                {
                    foreach (Teacher teacher in department.Teachers)
                    {
                        Console.WriteLine($"\t{teacher.Firstname} {teacher.Lastname}");
                    }
                }
            }
        }

        public void AddFaculties()
        {
            Console.WriteLine("Add Faculty");
            //// пакетная вставка, с использованием анонимных объектов
            //var faculties = new List<object>();
            //for (int i = 1; i <= 5; i++)
            //{
            //    faculties.Add(new { Name = "Faculty " + i });
            //}

            // пакетная вставка, с использованием типизированных объектов
            var faculties = new List<Faculty>();
            for (int i = 11; i <= 15; i++)
            {
                faculties.Add(new Faculty { Name = "Faculty " + i });
            }

            var result = dbConnection.Execute("insert into Faculties(Name) values(@Name)", faculties);
            Console.WriteLine("\nResult = " + result);
        }

        public void DeleteFaculties()
        {
            Console.WriteLine("Delete Faculty");
            // пакетное удаление, с использованием анонимных объектов
            var faculties = new List<int>();
            int id = 0;
            while (true)
            {
                Console.Write("Enter Id (write -1 to break) = ");
                id = int.Parse(Console.ReadLine());
                if (id < 0)
                    break;
                faculties.Add(id);
            }

            // открытие транзакции
            IDbTransaction tran = dbConnection.BeginTransaction();
            try
            {
                var result = dbConnection.Execute("delete from Faculties where (Id in @faculties)"
                    , new { faculties }, transaction: tran);
                Console.WriteLine("\nAffected records = " + result);

                tran.Commit();

                PrintFaculties();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateFaculties()
        {
            Console.WriteLine("Update Faculty");
            PrintFaculties();
            // обновление
            var faculty = new Faculty();
            Console.Write("\nEnetr Id = ");
            faculty.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter new name = ");
            faculty.Name = Console.ReadLine();
            
            // открытие транзакции
            IDbTransaction tran = dbConnection.BeginTransaction();
            try
            {
                var result = dbConnection.Execute("update Faculties set Name = @Name where (Id = @Id)", 
                    faculty, transaction: tran);
                Console.WriteLine("\nAffected records = " + result);

                tran.Commit();

                PrintFaculties();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintFaculties()
        {
            Console.WriteLine("\nPrint Faculty");
            var faculties = dbConnection.Query<Faculty>("select * from Faculties");
            foreach (Faculty faculty in faculties)
            {
                Console.WriteLine($"{faculty.Id} - {faculty.Name}");
            }
        }

        public void MultiQueryDapper()
        {
            string sql = "select * from Teachers;" +
                "select * from Faculties;" +
                "select * from Groups;";

            using (var multi=dbConnection.QueryMultiple(sql))
            {
                var teachers = multi.Read<Teacher>().ToList();
                var faculties = multi.Read<Faculty>().ToList();
                var groups = multi.Read<Group>().ToList();

                Console.WriteLine("Teachers list: ");
                foreach (Teacher teacher in teachers)
                {
                    Console.WriteLine($"\t{teacher.Firstname} {teacher.Lastname}");
                }

                Console.WriteLine("Faculties list: ");
                foreach (Faculty faculty in faculties)
                {
                    Console.WriteLine($"\t{faculty.Name}");
                }

                Console.WriteLine("Groups list: ");
                foreach (Group group in groups)
                {
                    Console.WriteLine($"\t{group.Name} - {group.StudentsCount}");
                }
            } 
        }

        public void PrintGroupFaculty()
        {
            Console.Write("Enter faculty id = ");
            int id = int.Parse(Console.ReadLine());

            var result = dbConnection.Query("GroupsOnFaculty" 
                , new {id}
                , commandType: CommandType.StoredProcedure);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void ExecuteScalarFunc()
        {
            Console.Write("FirstName = ");
            string firstName = Console.ReadLine();
            Console.Write("LastName = ");
            string lastName = Console.ReadLine();
            var result = dbConnection.ExecuteScalar<int>(
                "select dbo.GetSubjectCount(@firstName, @lastName)"
                , new { firstName, lastName });

            Console.WriteLine("\nResult = " + result);
        }

        public void ExecuteScalarStudentsCount()
        {
            var result = dbConnection.ExecuteScalar<int>("select count(*) from Students");

            Console.WriteLine("\nStudentsCount = " + result);
        }
    }
}
