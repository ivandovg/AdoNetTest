using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Ado2_1
{
    internal class Program2_1
    {
        static void Main(string[] args)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString;
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString);
            
            SqlConnection connection = new SqlConnection(sb.ToString());
            
            try
            {
                connection.Open();
                Console.WriteLine($"Current state: {connection.State}");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadLine();
            }
        }
    }
}
