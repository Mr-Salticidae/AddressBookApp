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
    public partial class EditContactForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public EditContactForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_EditContact_Click(object sender, EventArgs e)
        {
            if (txt_Name.TextLength > 0 && (combo_Sex.Text.Length > 0 || txt_OfficeTel.TextLength > 0 || txt_HomeTel.TextLength > 0 || combo_Mark.Text.Length > 0))
            {
                connection.Open();

                OleDbCommand checkCommand = new OleDbCommand();
                checkCommand.Connection = connection;
                checkCommand.CommandText = "select * from TelephoneInfo where PersonName = '" + txt_Name + "'";
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
                    MessageBox.Show("Invalid contact name.");
                }
                else
                {
                    if (combo_Sex.Text.Length > 0)
                    {
                        OleDbCommand insertCommand = new OleDbCommand();
                        insertCommand.Connection = connection;
                        insertCommand.CommandText = "update TelephoneInfo set [Sex] = '" + combo_Sex.Text + "' where PersonName = '" + txt_Name.Text + "'";
                        insertCommand.ExecuteNonQuery();
                    }
                    if (txt_OfficeTel.Text.Length > 0)
                    {
                        OleDbCommand insertCommand = new OleDbCommand();
                        insertCommand.Connection = connection;
                        insertCommand.CommandText = "update TelephoneInfo set [Sex] = '" + txt_OfficeTel.Text + "' where PersonName = '" + txt_Name.Text + "'";
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("");
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter at least one information to edit.");
            }
        }
    }
}
