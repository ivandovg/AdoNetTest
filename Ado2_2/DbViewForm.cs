using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado2_2
{
    public partial class DbViewForm : Form
    {
        private const string sqlTeachersSelect = "select * from Teachers";
        private const string sqlGroupsSelect = "select * from Groups";
        private SqlConnection sqlConnection;
        public DbViewForm(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;

            InitializeComponent();
            dgvTeachers.MultiSelect = false;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.ReadOnly = true;

            UpdateTechersView();
        }

        private void UpdateTechersView()
        {
            dgvTeachers.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlTeachersSelect, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvTeachers.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTechersView();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            
            string sql = "WAITFOR DELAY '00:00:05'; INSERT INTO[Teachers]([Firstname], [Lastname], [Birthdate], [DepartmentId]) VALUES(@firstName,@lastName,@birth,@dep)";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            try
            {
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@firstName", edFirstname.Text));
                command.Parameters.Add(new SqlParameter("@lastName", edLastname.Text));

                SqlParameter birth = new SqlParameter("@birth", SqlDbType.Date);
                birth.Value = edBirthdate.Value;
                command.Parameters.Add(birth);

                SqlParameter dep = new SqlParameter("@dep", SqlDbType.Int);
                dep.Value = (int)edDepartment.Value;
                command.Parameters.Add(dep);
                // v1
                //await command.ExecuteNonQueryAsync();

                // v2 use callback
                var state = command.BeginExecuteNonQuery(ExecuteQueryCallback, command);

                //// v3
                //while (!state.IsCompleted)
                //{
                //    // что-то выполняем пока работает асинхронная команда
                //}
                // заверщаем асинхронный вызов
                //int result = command.EndExecuteNonQuery(state);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //btnAdd.Enabled = true;
                //UpdateTechersView();
            }
        }

        private void ExecuteQueryCallback(IAsyncResult result)
        {
            // получаем ссылку на объект, который запустил асинхронную опреацию
            SqlCommand command=result.AsyncState as SqlCommand;
            if (command == null)
                return;

            // завершаем асинхронную операцию
            int rowcount = command.EndExecuteNonQuery(result);

            // обновить DataGridView
            Action a = () =>
            {
                btnAdd.Enabled = true;
                UpdateTechersView();
            };
            if (InvokeRequired)
            {
                Invoke(a);
            }
            else
            {
                a();
            }
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            dgvGroups.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlGroupsSelect, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvGroups.DataSource = table;
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            btnAddGroup.Enabled = false;
            SqlCommand command = new SqlCommand("AddNewGroup", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@groupName", edGroupName.Text));
            command.Parameters.Add(new SqlParameter("@faculty", (int)edFacultyId.Value));

            SqlParameter groupId = new SqlParameter("@groupId", SqlDbType.Int);
            groupId.Direction = ParameterDirection.Output;
            command.Parameters.Add(groupId);

            try
            {
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Group id = " + groupId.Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAddGroup.Enabled = true;
                btnUpdateGroup_Click(sender, e);
            }
        }
    }
}
