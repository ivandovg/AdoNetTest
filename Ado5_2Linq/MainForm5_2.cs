using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado5_2Linq
{
    public partial class MainForm5_2 : Form
    {
        private const string connectionString = "Data Source=(local)\\sqlexpress;Initial Catalog=TeachersDb;Integrated Security=True";
        private TeachersDbDataContext teachersDb;
        public MainForm5_2()
        {
            InitializeComponent();
            teachersDb = new TeachersDbDataContext(connectionString);
            //dataGridView1.DataSource = teachersDb.Subjects.ToList();

            // отоюбразить полное имя преподавателя, дату рождения и название кафедры
            var teachers = from d in teachersDb.Departments
                           join t in teachersDb.Teachers on d equals t.Departments
                           orderby t.Firstname, t.Lastname
                           select new
                           {
                               Fullname = $"{t.Firstname} {t.Lastname}",
                               Birth = t.Birthdate,
                               d.Department
                           };

            dataGridView1.DataSource = teachers.ToList();
        }
    }
}
