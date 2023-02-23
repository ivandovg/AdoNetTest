namespace Ado11_1
{
    internal class Program11_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Test Dapper ORM";
            TeachersDbContext teachersDb = new TeachersDbContext();

            //// вывести список преподавателей, используя динамические объекты
            //teachersDb.PrintAllTeachers();
            //// вывести преподавателей по Id, используя динамические объекты
            //teachersDb.PrintTeacherById(3);

            // вывести список преподавателей, используя типизированные объекты
            // teachersDb.PrintAllTeachersTypicaly();

            // вывести список преподавателей и название кафедры
            //teachersDb.PrintAllTeachersAndDepartments();

            // добавить группу
            // teachersDb.AddNewGroup();

            // отобразить название кафедры и преподавателей
            //teachersDb.PrintDepartmentAndTeachers();

            // добавить факультеты и вывести список на консоль
            //teachersDb.AddFaculties();
            //teachersDb.PrintFaculties();

            // пакетное удаление, с использованием анонимных объектов и вывести список на консоль
            //teachersDb.PrintFaculties();
            //teachersDb.DeleteFaculties();
            //teachersDb.PrintFaculties();

            // обновить запись
            // teachersDb.UpdateFaculties();

            // мультизапрос
            //teachersDb.MultiQueryDapper();

            // использование хранимой процедуры, которая возвращает таблицу
            // teachersDb.PrintGroupFaculty();

            // получение скалярных значений
            //teachersDb.ExecuteScalarFunc(); // вызов пользовательской скалярной функции
            teachersDb.ExecuteScalarStudentsCount(); // вызов итоговой функции

            Console.WriteLine("\npress ENTER key...");
            Console.ReadLine();
        }
    }
}