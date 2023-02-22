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
            teachersDb.PrintDepartmentAndTeachers();

            Console.WriteLine("\npress ENTER key...");
            Console.ReadLine();
        }
    }
}