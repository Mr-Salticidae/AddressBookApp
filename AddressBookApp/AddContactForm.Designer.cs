namespace AddressBookApp
{
    partial class AddContactForm
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
            this.components = new System.ComponentModel.Container();
            this.txt_OfficeTel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_Mark = new System.Windows.Forms.ComboBox();
            this.combo_Sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HomeTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.addressBookDataSet = new AddressBookApp.AddressBookDataSet();
            this.addressBookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneInfoTableAdapter = new AddressBookApp.AddressBookDataSetTableAdapters.TelephoneInfoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OfficeTel
            // 
            this.txt_OfficeTel.Location = new System.Drawing.Point(169, 117);
            this.txt_OfficeTel.Name = "txt_OfficeTel";
            this.txt_OfficeTel.Size = new System.Drawing.Size(129, 25);
            this.txt_OfficeTel.TabIndex = 13;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(169, 40);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(129, 25);
            this.txt_Name.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Office Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_Mark);
            this.groupBox1.Controls.Add(this.combo_Sex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_HomeTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_OfficeTel);
            this.groupBox1.Controls.Add(this.btn_GoBack);
            this.groupBox1.Controls.Add(this.btn_AddUser);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(98, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 313);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Contact";
            // 
            // combo_Mark
            // 
            this.combo_Mark.FormattingEnabled = true;
            this.combo_Mark.Items.AddRange(new object[] {
            "Family",
            "Friends",
            "Classmates",
            "Workmates"});
            this.combo_Mark.Location = new System.Drawing.Point(169, 199);
            this.combo_Mark.Name = "combo_Mark";
            this.combo_Mark.Size = new System.Drawing.Size(129, 23);
            this.combo_Mark.TabIndex = 16;
            // 
            // combo_Sex
            // 
            this.combo_Sex.FormattingEnabled = true;
            this.combo_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_Sex.Location = new System.Drawing.Point(169, 80);
            this.combo_Sex.Name = "combo_Sex";
            this.combo_Sex.Size = new System.Drawing.Size(129, 23);
            this.combo_Sex.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mark";
            // 
            // txt_HomeTel
            // 
            this.txt_HomeTel.Location = new System.Drawing.Point(169, 158);
            this.txt_HomeTel.Name = "txt_HomeTel";
            this.txt_HomeTel.Size = new System.Drawing.Size(129, 25);
            this.txt_HomeTel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Home Telephone";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(198, 242);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(80, 31);
            this.btn_GoBack.TabIndex = 18;
            this.btn_GoBack.Text = "OK";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(61, 242);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(80, 31);
            this.btn_AddUser.TabIndex = 17;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // addressBookDataSet
            // 
            this.addressBookDataSet.DataSetName = "AddressBookDataSet";
            this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBookDataSetBindingSource
            // 
            this.addressBookDataSetBindingSource.DataSource = this.addressBookDataSet;
            this.addressBookDataSetBindingSource.Position = 0;
            // 
            // telephoneInfoBindingSource
            // 
            this.telephoneInfoBindingSource.DataMember = "TelephoneInfo";
            this.telephoneInfoBindingSource.DataSource = this.addressBookDataSetBindingSource;
            // 
            // telephoneInfoTableAdapter
            // 
            this.telephoneInfoTableAdapter.ClearBeforeFill = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddContactForm";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_OfficeTel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_HomeTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Mark;
        private System.Windows.Forms.ComboBox combo_Sex;
        private System.Windows.Forms.BindingSource addressBookDataSetBindingSource;
        private AddressBookDataSet addressBookDataSet;
        private System.Windows.Forms.BindingSource telephoneInfoBindingSource;
        private AddressBookDataSetTableAdapters.TelephoneInfoTableAdapter telephoneInfoTableAdapter;
    }
}