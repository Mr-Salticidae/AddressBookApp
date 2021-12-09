namespace AddressBookApp
{
    partial class EditContactForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_Mark = new System.Windows.Forms.ComboBox();
            this.combo_Sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HomeTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_OfficeTel = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_Mark);
            this.groupBox1.Controls.Add(this.combo_Sex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_HomeTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_OfficeTel);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.btn_EditUser);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 357);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Contact";
            // 
            // combo_Mark
            // 
            this.combo_Mark.FormattingEnabled = true;
            this.combo_Mark.Items.AddRange(new object[] {
            "Family",
            "Friends",
            "Classmates",
            "Workmates"});
            this.combo_Mark.Location = new System.Drawing.Point(165, 219);
            this.combo_Mark.Name = "combo_Mark";
            this.combo_Mark.Size = new System.Drawing.Size(129, 23);
            this.combo_Mark.TabIndex = 17;
            // 
            // combo_Sex
            // 
            this.combo_Sex.FormattingEnabled = true;
            this.combo_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_Sex.Location = new System.Drawing.Point(165, 100);
            this.combo_Sex.Name = "combo_Sex";
            this.combo_Sex.Size = new System.Drawing.Size(129, 23);
            this.combo_Sex.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mark";
            // 
            // txt_HomeTel
            // 
            this.txt_HomeTel.Location = new System.Drawing.Point(165, 178);
            this.txt_HomeTel.Name = "txt_HomeTel";
            this.txt_HomeTel.Size = new System.Drawing.Size(129, 25);
            this.txt_HomeTel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Home Telephone";
            // 
            // txt_OfficeTel
            // 
            this.txt_OfficeTel.Location = new System.Drawing.Point(165, 137);
            this.txt_OfficeTel.Name = "txt_OfficeTel";
            this.txt_OfficeTel.Size = new System.Drawing.Size(129, 25);
            this.txt_OfficeTel.TabIndex = 14;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(194, 264);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(80, 31);
            this.btn_OK.TabIndex = 18;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(57, 264);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(80, 31);
            this.btn_EditUser.TabIndex = 17;
            this.btn_EditUser.Text = "Edit";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditContact_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(165, 60);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(129, 25);
            this.txt_Name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Office Telephone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sex";
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditContactForm";
            this.Text = "Charles Address Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Mark;
        private System.Windows.Forms.ComboBox combo_Sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HomeTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_OfficeTel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}