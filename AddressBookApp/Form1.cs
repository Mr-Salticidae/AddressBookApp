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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./AddressBook.mdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            checkConnection.Text = "Succeed";
            connection.Close();
        }
    }
}
