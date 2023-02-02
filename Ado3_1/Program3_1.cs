using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado3_1
{
    internal class Program3_1
    {
        private static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString;
        static void Main(string[] args)
        {
            Console.Title = "Test MultiQueries";
            ShowTables();

            Console.WriteLine("\npress any key...");
            Console.ReadKey();
        }

        private static void ShowTables()
        {
            // текст запроса к БД
            string sql = "select * from Groups; " +
                "select * from Students; " +
                "select * from Subjects;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // открыть подключение
                conn.Open();

                // команда на выполнение запроса
                SqlCommand command = new SqlCommand(sql, conn);

                // запуск команды, получение объекта SqlDataReader для чтения результата запроса из БД
                SqlDataReader reader = command.ExecuteReader();

                do
                {
                    // разбираем полученный результат запроса для таблицы
                    bool first = true;
                    while (reader.Read())
                    {
                        // выводим заголовок таблицы
                        if (first)
                        {
                            first = false;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i)}\t");
                            }
                            Console.WriteLine();
                        }
                        // выводим текущую строку таблицы
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader[i]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    // переход к следующему результату
                } while (reader.NextResult());
            }

        }
    }
}
