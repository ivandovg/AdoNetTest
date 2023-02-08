using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado5_1Linq
{
    public partial class MainForm : Form
    {
        private const string connectionString = "Data Source=(local)\\sqlexpress;Initial Catalog=BookSales;Integrated Security=True";
        // контекст базы данных
        private DataContext dbContext;
        //private Table<User> users;
        
        public MainForm()
        {
            InitializeComponent();
            // создаем контекст и подключаемся к БД
            dbContext = new DataContext(connectionString);
            // получаем выборку из таблицы
            dgvUsersView.DataSource = dbContext.GetTable<User>().ToList();

            //users=dbContext.GetTable<User>();
            //dgvUsersView.DataSource = users.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edLogin.Text) || string.IsNullOrEmpty(edPassword.Text))
                return;

            //dgvUsersView.DataSource = null;

            // для добавления записи, создаем объект
            User user = new User()
            {
                UserLogin = edLogin.Text,
                Password = edPassword.Text,
                Allow = cbAllowUser.Checked
            };

            // добавляем запись в контекст БД
            dbContext.GetTable<User>().InsertOnSubmit(user);
            // сохранить изменеия в БД
            //dbContext.SubmitChanges();
            //dgvUsersView.DataSource = dbContext.GetTable<User>().ToList();
            btnSave_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbContext.SubmitChanges();
            dgvUsersView.DataSource = null;
            dgvUsersView.DataSource = dbContext.GetTable<User>().ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsersView.SelectedRows.Count < 1)
                return;

            User user = dgvUsersView.SelectedRows[0].DataBoundItem as User;
            if (user == null)
                return;

            // v1
            dbContext.GetTable<User>().DeleteOnSubmit(user);
            btnSave_Click(null, null);

            // v2
            //dgvUsersView.DataSource = null;

            //dbContext.GetTable<User>().DeleteOnSubmit(user);
            //dbContext.SubmitChanges();
            //dgvUsersView.DataSource = dbContext.GetTable<User>().ToList();
        }

        private void dgvUsersView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsersView.SelectedRows.Count < 1)
                return;

            User user = dgvUsersView.SelectedRows[0].DataBoundItem as User;
            if (user == null)
                return;

            edLogin.Text = user.UserLogin;
            edPassword.Text = user.Password;
            edDateCreated.Value = user.DateCreated;
            cbAllowUser.Checked = user.Allow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvUsersView.SelectedRows.Count < 1)
                return;

            User user = dgvUsersView.SelectedRows[0].DataBoundItem as User;
            if (user == null)
                return;

            //// v1 - обновление в таблице
            //user.UserLogin = edLogin.Text;
            //user.Password = edPassword.Text;
            //user.Allow = cbAllowUser.Checked;

            // v2 - обновление в таблице
            User userNew = dbContext.GetTable<User>().Where(u => u.Id == user.Id).FirstOrDefault();
            if (userNew != null)
            {
                userNew.UserLogin = edLogin.Text;
                userNew.Password = edPassword.Text;
                userNew.Allow = cbAllowUser.Checked;
                btnSave_Click(null, null);
            }
        }

        private void btnTestQuery_Click(object sender, EventArgs e)
        {
            // v1 - показать имя пользователя (Login) и дату создания пользователя (Date)
            //var users = (from u in dbContext.GetTable<User>()
            //            orderby u.UserLogin
            //            select new { Login = u.UserLogin, Date = u.DateCreated }).Take(5);
            //dgvUsersView.DataSource = users.ToList();

            // v2
            dgvUsersView.DataSource = dbContext.GetTable<User>()
                .Select(u=>new { Login = u.UserLogin, Date = u.DateCreated })
                .OrderBy(u=> u.Login)
                .Take(5)
                .ToList();

            //var users = (from u in table1
            //            join t in table2 on t equals u.поле-связь 
            //            orderby u.UserLogin
            //            select new { Login = u.UserLogin, Date = u.DateCreated }).Take(5);
            //dgvUsersView.DataSource = users.ToList();
        }
    }
}
