using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
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
    }
}
