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
    public partial class DeleteContactForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public DeleteContactForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_DeleteContact_Click(object sender, EventArgs e)
        {
            if (txt_Name.TextLength > 0)
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from TelephoneInfo where PersonName = '" + txt_Name.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }

                connection.Close();

                if (count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to delete Contact " + txt_Name.Text + "?", "Alert!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        connection.Open();

                        OleDbCommand deleteCommand = new OleDbCommand();
                        command.Connection = connection;
                        command.CommandText = "delete from TelephoneInfo where PersonName = '" + txt_Name.Text + "'";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Contact " + txt_Name.Text + " has been deleted.");

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid name.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the name of Contact you want to delete.");
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
