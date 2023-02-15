using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado8_1EF
{
    public partial class MainForm : Form
    {
        ContactsDbContainer contactsDb;
        public MainForm()
        {
            InitializeComponent();
            // отключаю автогенерацию колонок
            dgvPeoples.AutoGenerateColumns = false;
            dgvContacts.AutoGenerateColumns = false;

            // создаем контекст БД
            contactsDb = new ContactsDbContainer();
            UpdateDataGridView();
        }

        private void UpdateDataGridView(bool saveChanges = false)
        {
            int id = -1;
            if (dgvPeoples.DataSource != null)
            {
                id = dgvPeoples.Rows.IndexOf(dgvPeoples.SelectedRows[0]);
            }

            dgvPeoples.DataSource = null;
            if (saveChanges)
            {
                contactsDb.SaveChanges();
            }

            dgvPeoples.DataSource = contactsDb.Peoples.ToList();
            if (id >= 0)
            {
                dgvPeoples.Rows[id].Selected = true;
            }
        }

        private void dgvPeoples_SelectionChanged(object sender, EventArgs e)
        {
            dgvContacts.DataSource = null;
            if (dgvPeoples.SelectedRows.Count == 0)
                return;

            Person person = dgvPeoples.SelectedRows[0].DataBoundItem as Person;

            if (person == null) return;

            dgvContacts.DataSource = person.Contacts.ToList();
        }

        private void btnPersonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Firstname = edPersonFirstname.Text,
                Lastname = edPersonLastname.Text,
                Birth = edPersonBirthdate.Value
            };
            contactsDb.Peoples.Add(person);

            UpdateDataGridView(true);
        }

        private void btnContactAdd_Click(object sender, EventArgs e)
        {
            if (dgvPeoples.SelectedRows.Count == 0)
                return;

            Person person = dgvPeoples.SelectedRows[0].DataBoundItem as Person;

            if (person == null) return;

            Contact contact = new Contact()
            {
                TypeInfo = edContactTypeInfo.Text,
                Value = edContactValue.Text
            };
            contact.Person = person;
            //int id = person.Id;

            contactsDb.Contacts.Add(contact);
            UpdateDataGridView(true);
        }
    }
}
