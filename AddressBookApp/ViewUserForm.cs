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
    public partial class ViewUserForm : Form
    {
        public ViewUserForm()
        {
            InitializeComponent();
        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.addressBookDataSet.UserInfo);
            // TODO: This line of code loads data into the 'addressBookDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.addressBookDataSet.UserInfo);

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

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
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

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
