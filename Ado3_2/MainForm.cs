using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado3_2
{
    public partial class MainForm : Form
    {
        private TeachersDb teachersDb;
        public MainForm()
        {
            teachersDb = new TeachersDb(System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString);

            InitializeComponent();

            // заполняем таблицы из БД
            teachersDb.FillTables();

            // отображаем список таблиц
            cmbTables.DataSource = teachersDb.TableNames;
            //cmbTables.DisplayMember = "";
            //cmbTables.ValueMember = "";
            //object i = cmbTables.SelectedValue;

            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = teachersDb.TeachersSet.Tables[cmbTables.SelectedItem.ToString()];
        }

        private void btnFillTables_Click(object sender, EventArgs e)
        {
            teachersDb.FillTables();
        }
    }
}
