namespace AddressBookApp
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AddUsername = new System.Windows.Forms.TextBox();
            this.txt_AddPassword = new System.Windows.Forms.TextBox();
            this.txt_AddRepeatPassword = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat Password";
            // 
            // txt_AddUsername
            // 
            this.txt_AddUsername.Location = new System.Drawing.Point(280, 139);
            this.txt_AddUsername.Name = "txt_AddUsername";
            this.txt_AddUsername.Size = new System.Drawing.Size(100, 25);
            this.txt_AddUsername.TabIndex = 3;
            // 
            // txt_AddPassword
            // 
            this.txt_AddPassword.Location = new System.Drawing.Point(280, 179);
            this.txt_AddPassword.Name = "txt_AddPassword";
            this.txt_AddPassword.PasswordChar = '*';
            this.txt_AddPassword.Size = new System.Drawing.Size(100, 25);
            this.txt_AddPassword.TabIndex = 4;
            // 
            // txt_AddRepeatPassword
            // 
            this.txt_AddRepeatPassword.Location = new System.Drawing.Point(280, 216);
            this.txt_AddRepeatPassword.Name = "txt_AddRepeatPassword";
            this.txt_AddRepeatPassword.PasswordChar = '*';
            this.txt_AddRepeatPassword.Size = new System.Drawing.Size(100, 25);
            this.txt_AddRepeatPassword.TabIndex = 5;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(61, 158);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(80, 31);
            this.btn_AddUser.TabIndex = 6;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GoBack);
            this.groupBox1.Controls.Add(this.btn_AddUser);
            this.groupBox1.Location = new System.Drawing.Point(106, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(184, 158);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(80, 31);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.txt_AddRepeatPassword);
            this.Controls.Add(this.txt_AddPassword);
            this.Controls.Add(this.txt_AddUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUserForm";
            this.Text = "Charles Address Book";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AddUsername;
        private System.Windows.Forms.TextBox txt_AddPassword;
        private System.Windows.Forms.TextBox txt_AddRepeatPassword;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GoBack;
    }
}