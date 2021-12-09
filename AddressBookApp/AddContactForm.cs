using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class AddContactForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public AddContactForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ViewUserForm viewUserForm = new ViewUserForm();
            viewUserForm.ShowDialog();
        }

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.TelephoneInfo' table. You can move, or remove it, as needed.
            this.telephoneInfoTableAdapter.Fill(this.addressBookDataSet.TelephoneInfo);

        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (txt_Name.TextLength > 0 && combo_Sex.Text.Length > 0 && txt_OfficeTel.TextLength > 0 && txt_HomeTel.TextLength > 0 && combo_Mark.Text.Length > 0)
            {
                connection.Open();

                OleDbCommand checkCommand = new OleDbCommand();
                checkCommand.Connection = connection;
                checkCommand.CommandText = "select * from TelephoneInfo where PersonName = '" + txt_Name.Text + "'";
                OleDbDataReader reader = checkCommand.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }

                connection.Close();

                connection.Open();

                if (count == 0)
                {
                    OleDbCommand insertCommand = new OleDbCommand();
                    insertCommand.Connection = connection;
                    insertCommand.CommandText = "insert into TelephoneInfo ([PersonName], [Sex], [OfficeTel], [HomeTel], [Mark]) values ('" + txt_Name.Text + "','" + combo_Sex.Text + "','" + txt_OfficeTel.Text + "','" + txt_HomeTel.Text + "','" + combo_Mark.Text + "')";
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Add New Contact Successfully!");
                }
                else
                {
                    MessageBox.Show("The contact has already existed.");
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Please make sure enter all of the information required.");
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
