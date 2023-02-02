using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ado3_2
{
    internal class TeachersDb
    {
        public const string tableGroups = "Groups";
        public const string tableStudents = "Students";
        public const string tableSubjects = "Subjects";
        public string[] TableNames = { tableGroups, tableStudents, tableSubjects };

        private SqlConnection sqlConnection;
        private string connectionString;
        private DataSet dataSet;

        public DataSet TeachersSet => dataSet;

        public TeachersDb(string connectionString)
        {
            // подключение к БД
            this.connectionString = connectionString;

            // хранилище результатов
            dataSet = new DataSet("TeachersDb");
        }
        public void FillTables()
        {
            // очистка хранилища
            dataSet.Tables.Clear();

            // текст запроса к БД
            string sql = "select * from " + tableGroups + "; " +
                "select * from " + tableStudents + "; " +
                "select * from " + tableSubjects + ";";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                // открыть подключение
                sqlConnection.Open();

                // команда на выполнение запроса
                SqlCommand command = new SqlCommand(sql, sqlConnection);

                // запуск команды, получение объекта SqlDataReader для чтения результата запроса из БД
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int t = 0;
                    do
                    {
                        // разбираем полученный результат запроса для таблиц
                        // создаем таблицы
                        DataTable table = new DataTable(TableNames[t]);
                        t++;

                        // поместить таблицу в хранилище
                        dataSet.Tables.Add(table);

                        bool first = true;
                        while (reader.Read())
                        {
                            // выводим заголовок таблицы
                            if (first)
                            {
                                first = false;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    // добавляем колонки в таблицу
                                    table.Columns.Add(new DataColumn(reader.GetName(i)));
                                }
                            }
                            //создаем строку для таблицы
                            DataRow row = table.NewRow();

                            // добавляем строку в таблицу
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                //заполняем строку для таблицы
                                row[i] = reader[i];
                            }
                            // добавляем строку в таблицу
                            table.Rows.Add(row);
                        }
                        // переход к следующему результату
                    } while (reader.NextResult());
                }
            }

        }
    }
}
