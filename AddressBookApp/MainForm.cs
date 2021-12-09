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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ViewUserForm viewUserForm = new ViewUserForm();
            viewUserForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.TelephoneInfo' table. You can move, or remove it, as needed.
            this.telephoneInfoTableAdapter.Fill(this.addressBookDataSet.TelephoneInfo);
            // TODO: This line of code loads data into the 'addressBookDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.addressBookDataSet.UserInfo);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog();
        }
    }
}
