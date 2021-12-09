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
    public partial class DeleteUserForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public DeleteUserForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from UserInfo where Username = '" + txt_Username.Text + "' and Password = '" + txt_Password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            connection.Close();

            if (count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete User " + txt_Username.Text + "?", "Alert!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Open();

                    OleDbCommand deleteCommand = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "delete from UserInfo where Username = '" + txt_Username.Text + "'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("User " + txt_Username.Text + " has been deleted.");

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
