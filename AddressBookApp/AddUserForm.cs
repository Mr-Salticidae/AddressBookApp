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
    public partial class AddUserForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public AddUserForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {

            if (txt_AddUsername.TextLength > 0 && txt_AddPassword.TextLength > 0 && txt_AddRepeatPassword.TextLength > 0)
            {
                if (txt_AddPassword.Text == txt_AddRepeatPassword.Text)
                {
                    connection.Open();

                    OleDbCommand checkCommand = new OleDbCommand();
                    checkCommand.Connection = connection;
                    checkCommand.CommandText = "select * from UserInfo where Username = '" + txt_AddUsername.Text + "'";
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
                        insertCommand.CommandText = "insert into UserInfo ([Username], [Password]) values ('" + txt_AddUsername.Text + "','" + txt_AddPassword.Text + "')";
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Add A New User Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("The user has already existed.");
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("The passwords are not the same.");
                }
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
