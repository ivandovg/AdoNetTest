using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado1_1
{
    internal class Program1_1
    {
        static void Main(string[] args)
        {
            // Data Source=localhost
            // Data Source=192.168.1.1
            // Data Source=192.168.1.1\\SQLEXPRESS
            // Data Source=(local)\\SQLEXPRESS
            // Data Source=(local)
            // Data Source=192.168.1.1\\MSSQL
            // Data Source=(local)\\MSSQL

            string connectionStr = "Data Source=DESKTOP-ALEU41I\\SQLEXPRESS;Initial Catalog=TeachersDb;Integrated Security=true"; // true|yes|sspi
            //string connectionStr = "Data Source=DESKTOP-ALEU41I\\SQLEXPRESS;Initial Catalog=TeachersDb;User ID=user1; Password=1234"; 
            
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                // открыть подключение
                try
                {
                    conn.Open();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ShowTable("Faculties", conn);
                ShowScalarValue("Faculties", conn);
                //InsertFaculty(conn);
                //Console.WriteLine("After insert record");
               
                DeleteFaculty(conn);
                Console.WriteLine("After delete record");
                ShowTable("Faculties", conn);

            }
            Console.WriteLine("\n\npress enter key...");
            Console.ReadLine();
        }

        static void ShowTable(string tableName, SqlConnection connection)
        {
            // текст запроса
            string sql = "select * from " + tableName;

            // команда, вариант 1
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;

            // команда, вариант 2
            SqlCommand cmd = new SqlCommand(sql, connection);

            // вывод результата
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                bool first = true;
                while (reader.Read())
                {
                    // reader["id"] - получить значение из поля с именем "id"

                    if (first)
                    {
                        first = false;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine();
                    }

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }

        static void ShowScalarValue(string tableName, SqlConnection connection)
        {
            // текст запроса
            string sql = "select count(*) from " + tableName;

            // команда
            SqlCommand cmd = new SqlCommand(sql, connection);
            int result;
            if (int.TryParse(cmd.ExecuteScalar().ToString(), out result))
            {
                Console.WriteLine("Record count = "+result);
            }
            else
            {
                Console.WriteLine("Cannot execute querie!");
            }
        }

        static void InsertFaculty(SqlConnection connection)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty!!!");
                return;
            }

            //SqlParameter parameter = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            //parameter.Value = name;
            string sql = "insert into Faculties values(@name)";
            SqlCommand command = new SqlCommand(sql, connection);
            //command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@name", name));
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record(s) affected");
        }

        static void DeleteFaculty(SqlConnection connection)
        {
            Console.Write("\nEnter Id: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error Id");
                return;
            }

            string sql = "delete from Faculties where (Id = @id)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record(s) affected");
        }
    }
}
