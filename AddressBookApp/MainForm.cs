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

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContactForm deleteContactForm = new DeleteContactForm();
            deleteContactForm.ShowDialog();
        }
    }
}
