using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado3_3
{
    public partial class MainForm : Form
    {
        private string connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString;

        // адаптер для выполнения запросов к таблице Teachers
        SqlDataAdapter adapter;
        // таблица преподавателей
        DataTable teachers;

        SqlCommandBuilder commandBuilder;

        public MainForm()
        {
            InitializeComponent();

            adapter = new SqlDataAdapter("select * from Teachers", connectionStr);
            // построить команды для обновления данных
            commandBuilder = new SqlCommandBuilder(adapter);
            teachers = new DataTable("Teachers");

            // ручное добавление команд
            //var i = new SqlCommand("", new SqlConnection(connectionStr));
            //i.CommandType = CommandType.StoredProcedure; - если хранимая процедура
            // ... добавить параметры для команды
            //adapter.InsertCommand = i;

            btnUpdate_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTeachers.DataSource = null;
            teachers.Clear();
            adapter.Fill(teachers);
            dgvTeachers.DataSource = teachers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // сохранить (зафиксировать) изменения в БД
            adapter.Update(teachers);
            // обновить грид
            btnUpdate_Click(null, null);
        }
    }
}
