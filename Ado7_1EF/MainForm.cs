using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado7_1EF
{
    public partial class MainForm : Form
    {
        private TeachersDbEntities dbEntities;
        public MainForm()
        {
            InitializeComponent();
            ApplyDataGridSettings();

            // создаем объект подключения к БД
            dbEntities = new TeachersDbEntities();

            // отображаем список кафедр
            btnDepartmentUpdate_Click(null, null);
            // отображаем список преподавателей
            UpdateTeachersList();
        }

        private void ApplyDataGridSettings()
        {
            // отключаю автогенерацию колонок для DataGridView
            dgvDepartments.AutoGenerateColumns = false;
            dgvTeachers.AutoGenerateColumns = false;

            // стиль выделения строки установим = FullRowSelect
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // отключить мульти-выделение строк
            dgvDepartments.MultiSelect = false;
            dgvTeachers.MultiSelect = false;
        }

        private void UpdateTeachersList()
        {
            dgvTeachers.DataSource = null;

            dgvTeachers.DataSource = dbEntities.Teachers.ToList();

            colTeacherDepartment.DataPropertyName = "DepartmentId";
            colTeacherDepartment.DataSource = dbEntities.Departments.ToList();
            colTeacherDepartment.DisplayMember = "Department1";
            colTeacherDepartment.ValueMember = "Id";

            //cmbTeacherDepartment.DataPropertyName = "DepartmentId";
            cmbTeacherDepartment.DataSource = dbEntities.Departments.ToList();
            cmbTeacherDepartment.DisplayMember = "Department1";
            cmbTeacherDepartment.ValueMember = "Id";
        }

        private async void btnDepartmentAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edDepartmentName.Text) || string.IsNullOrEmpty(edDepartmentPhone.Text))
            {
                MessageBox.Show("Field cannot be empty!!!");
                return;
            }

            Department department = new Department()
            {
                Department1 = edDepartmentName.Text,
                Phone = edDepartmentPhone.Text
            };

            dbEntities.Departments.Add(department);

            await SaveAllChanges(btnDepartmentAdd);
            btnDepartmentUpdate_Click(null, null);
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            dgvDepartments.DataSource = null;
            // отображаем список кафедр
            dgvDepartments.DataSource = dbEntities.Departments.ToList();
        }

        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;

            Department department = dgvDepartments.SelectedRows[0].DataBoundItem as Department;
            if (department == null)
                return;

            edDepartmentName.Text = department.Department1;
            edDepartmentPhone.Text = department.Phone;
        }

        private async void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;

            Department department = dgvDepartments.SelectedRows[0].DataBoundItem as Department;
            if (department == null)
                return;

            // DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
            DialogResult result = MessageBox.Show("Delete record?", "Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            dbEntities.Departments.Remove(department);

            await SaveAllChanges(btnDepartmentDelete);
            btnDepartmentUpdate_Click(null, null);
        }

        private async void btnDepartmentSave_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
                return;

            Department department = dgvDepartments.SelectedRows[0].DataBoundItem as Department;
            if (department == null)
                return;

            department.Department1 = edDepartmentName.Text;
            department.Phone = edDepartmentPhone.Text;

            await SaveAllChanges(btnDepartmentSave);
            btnDepartmentUpdate_Click(null, null);
        }

        private void btnGetAllPeoples_Click(object sender, EventArgs e)
        {
            // вызов пользовательской функции
            dgvTest.DataSource = dbEntities.GetAllPeoples().ToList();
        }

        private async void btnTeachersAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edTeacherFirstname.Text) || string.IsNullOrEmpty(edTeacherLastname.Text))
            {
                MessageBox.Show("Field cannot be empty!!!");
                return;
            }

            // получаем выбранную кафедру со списка
            Department department = cmbTeacherDepartment.SelectedItem as Department;
            if (department == null) return;

            // создаем объект - Teacher
            Teacher teacher = new Teacher()
            {
                Firstname = edTeacherFirstname.Text,
                Lastname = edTeacherLastname.Text,
                Birthdate = edTeacherBirthdate.Value,
                Department = department
            };

            btnTeachersAdd.Enabled = false;

            // добавляем в локальное хранилище
            dbEntities.Teachers.Add(teacher);

            // сохраняем в БД
            await SaveAllChanges(btnTeachersAdd);
            UpdateTeachersList();
        }

        private async Task<int> SaveAllChanges(Button sender)
        {
            sender.Enabled = false;
            try
            {
                return await dbEntities.SaveChangesAsync();
            }
            finally
            {
                sender.Enabled = true;
            }
        }
    }
}
