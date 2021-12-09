using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AddressBookApp
{
    public partial class LoginForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public LoginForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_Login_Click(object sender, EventArgs e)
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

            if (count > 0)
            {
                connection.Close();
                connection.Dispose();
                Hide();

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and password are not correct!");
            }

            connection.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
