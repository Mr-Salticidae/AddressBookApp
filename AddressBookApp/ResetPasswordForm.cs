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
    public partial class ResetPasswordForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public ResetPasswordForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.TextLength > 0 && txt_OldPassword.TextLength > 0 && txt_NewPassword.TextLength > 0 && txt_RepeatNewPassword.TextLength > 0)
            {
                if (txt_NewPassword.Text == txt_RepeatNewPassword.Text)
                {
                    connection.Open();

                    OleDbCommand checkCommand = new OleDbCommand();
                    checkCommand.Connection = connection;
                    checkCommand.CommandText = "select * from UserInfo where Username = '" + txt_Username.Text + "' and Password = '" + txt_OldPassword.Text + "'";
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
                        MessageBox.Show("Invalid Username or Password.");
                    }
                    else
                    {
                        OleDbCommand updateCommand = new OleDbCommand();
                        updateCommand.Connection = connection;
                        updateCommand.CommandText = "update [UserInfo] set [Password] = '" + txt_NewPassword.Text + "' where Username = '" + txt_Username.Text + "'";
                        MessageBox.Show(updateCommand.CommandText);
                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("The password has been reset.");
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("The new passwords are not the same.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure enter all of the information required.");
            }
        }
    }
}
