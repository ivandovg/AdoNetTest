using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado4_1
{
    public partial class MainForm4_1 : Form
    {
        // информация для подключение к конкретной СУБД
        DbConnection dbConnection;
        // выбранная фабрика
        DbProviderFactory factory;

        // строка подключения для выбраного поставщика данных
        string connectionStr = "";

        public MainForm4_1()
        {
            InitializeComponent();
        }

        private void btnGetProvider_Click(object sender, EventArgs e)
        {
            // получить список поставщиков
            DataTable table = DbProviderFactories.GetFactoryClasses();
            dgvView.DataSource = table;

            // отобразить названия поставщика
            cmbProviderList.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                cmbProviderList.Items.Add(row["InvariantName"].ToString());
            }
            cmbProviderList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbProviderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(cmbProviderList.SelectedItem.ToString());
            dbConnection = factory.CreateConnection();
            connectionStr = GetConnectionString(cmbProviderList.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(connectionStr))
            {
                edConnectionString.Text = connectionStr;
                edSqlQuery.Enabled = true;
            }
            else
            {
                edConnectionString.Text = "";
                edSqlQuery.Enabled = false;
            }
        }

        private string GetConnectionString(string provider)
        {
            string result = null;
            ConnectionStringSettingsCollection settingsCollection = ConfigurationManager.ConnectionStrings;
            if (settingsCollection != null)
            {
                foreach (ConnectionStringSettings item in settingsCollection)
                {
                    if(item.ProviderName == provider)
                    {
                        result = item.ConnectionString;
                        break;
                    }
                }
            }

            return result;
        }

        private void edSqlQuery_TextChanged(object sender, EventArgs e)
        {
            if (edSqlQuery.Text.Length > 5)
            {
                btnExecuteAsync.Enabled = true;
                btnExecute.Enabled = true;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            dbConnection.ConnectionString = connectionStr;
            // создаем адаптер с помощью фабрики!!!
            DbDataAdapter adapter = factory.CreateDataAdapter();
            // #1 фабричный метод создания команды
            //adapter.SelectCommand = factory.CreateCommand();
            //adapter.SelectCommand.Connection = dbConnection;
            
            // #2 фабричный метод создания команды
            adapter.SelectCommand = dbConnection.CreateCommand();

            // текст запроса
            adapter.SelectCommand.CommandText = edSqlQuery.Text;

            // создать объект DataTable
            DataTable table = new DataTable();

            // очистить контент в DataGridView
            dgvView.DataSource = null;

            // выполнить запрос
            adapter.Fill(table);
            
            // отобразить результат выборки
            dgvView.DataSource = table;

        }

        private async void btnExecuteAsync_Click(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;
            btnExecuteAsync.Enabled = false;
            DbCommand command=dbConnection.CreateCommand();
            command.CommandText = edSqlQuery.Text;
            try
            {
                await command.ExecuteNonQueryAsync();
            }
            finally
            {
                btnExecute.Enabled = true;
                btnExecuteAsync.Enabled = true;
            }
        }
    }
}
