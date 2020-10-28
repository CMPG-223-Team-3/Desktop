namespace Desktop
{
    partial class Staff
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddStaff = new System.Windows.Forms.TabPage();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddUsername = new System.Windows.Forms.TextBox();
            this.textBoxAddLastname = new System.Windows.Forms.TextBox();
            this.textBoxAddFirstname = new System.Windows.Forms.TextBox();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.lblAddUsername = new System.Windows.Forms.Label();
            this.lblAddLastname = new System.Windows.Forms.Label();
            this.lblAddFirstname = new System.Windows.Forms.Label();
            this.tabPageDeleteStaff = new System.Windows.Forms.TabPage();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.comboBoxDeleteStaffID = new System.Windows.Forms.ComboBox();
            this.lblStaffIDdelete = new System.Windows.Forms.Label();
            this.tabPageUpStaff = new System.Windows.Forms.TabPage();
            this.btnUpStaff = new System.Windows.Forms.Button();
            this.comboBoxStaffIDUP = new System.Windows.Forms.ComboBox();
            this.lblStaffUP = new System.Windows.Forms.Label();
            this.textBoxPasswordUP = new System.Windows.Forms.TextBox();
            this.textBoxUPusername = new System.Windows.Forms.TextBox();
            this.textBoxUpLastname = new System.Windows.Forms.TextBox();
            this.textBoxUPFirstName = new System.Windows.Forms.TextBox();
            this.lblPasswordUP = new System.Windows.Forms.Label();
            this.lblUPuasername = new System.Windows.Forms.Label();
            this.lblUpLastname = new System.Windows.Forms.Label();
            this.lblUPfirstname = new System.Windows.Forms.Label();
            this.lblStaffHeading = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageAddStaff.SuspendLayout();
            this.tabPageDeleteStaff.SuspendLayout();
            this.tabPageUpStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddStaff);
            this.tabControl.Controls.Add(this.tabPageDeleteStaff);
            this.tabControl.Controls.Add(this.tabPageUpStaff);
            this.tabControl.Location = new System.Drawing.Point(11, 50);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 305);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAddStaff
            // 
            this.tabPageAddStaff.Controls.Add(this.btnAddStaff);
            this.tabPageAddStaff.Controls.Add(this.textBoxAddPassword);
            this.tabPageAddStaff.Controls.Add(this.textBoxAddUsername);
            this.tabPageAddStaff.Controls.Add(this.textBoxAddLastname);
            this.tabPageAddStaff.Controls.Add(this.textBoxAddFirstname);
            this.tabPageAddStaff.Controls.Add(this.lblAddPassword);
            this.tabPageAddStaff.Controls.Add(this.lblAddUsername);
            this.tabPageAddStaff.Controls.Add(this.lblAddLastname);
            this.tabPageAddStaff.Controls.Add(this.lblAddFirstname);
            this.tabPageAddStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAddStaff.Name = "tabPageAddStaff";
            this.tabPageAddStaff.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAddStaff.Size = new System.Drawing.Size(570, 279);
            this.tabPageAddStaff.TabIndex = 0;
            this.tabPageAddStaff.Text = "Add Waiter";
            this.tabPageAddStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(101, 200);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(56, 19);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.Location = new System.Drawing.Point(101, 148);
            this.textBoxAddPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddPassword.TabIndex = 7;
            // 
            // textBoxAddUsername
            // 
            this.textBoxAddUsername.Location = new System.Drawing.Point(101, 113);
            this.textBoxAddUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddUsername.Name = "textBoxAddUsername";
            this.textBoxAddUsername.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddUsername.TabIndex = 6;
            // 
            // textBoxAddLastname
            // 
            this.textBoxAddLastname.Location = new System.Drawing.Point(101, 79);
            this.textBoxAddLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddLastname.Name = "textBoxAddLastname";
            this.textBoxAddLastname.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddLastname.TabIndex = 5;
            // 
            // textBoxAddFirstname
            // 
            this.textBoxAddFirstname.Location = new System.Drawing.Point(101, 48);
            this.textBoxAddFirstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddFirstname.Name = "textBoxAddFirstname";
            this.textBoxAddFirstname.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddFirstname.TabIndex = 4;
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Location = new System.Drawing.Point(48, 150);
            this.lblAddPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(53, 13);
            this.lblAddPassword.TabIndex = 3;
            this.lblAddPassword.Text = "Password";
            // 
            // lblAddUsername
            // 
            this.lblAddUsername.AutoSize = true;
            this.lblAddUsername.Location = new System.Drawing.Point(46, 117);
            this.lblAddUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUsername.Name = "lblAddUsername";
            this.lblAddUsername.Size = new System.Drawing.Size(55, 13);
            this.lblAddUsername.TabIndex = 2;
            this.lblAddUsername.Text = "Username";
            // 
            // lblAddLastname
            // 
            this.lblAddLastname.AutoSize = true;
            this.lblAddLastname.Location = new System.Drawing.Point(44, 83);
            this.lblAddLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLastname.Name = "lblAddLastname";
            this.lblAddLastname.Size = new System.Drawing.Size(53, 13);
            this.lblAddLastname.TabIndex = 1;
            this.lblAddLastname.Text = "Lastname";
            // 
            // lblAddFirstname
            // 
            this.lblAddFirstname.AutoSize = true;
            this.lblAddFirstname.Location = new System.Drawing.Point(41, 52);
            this.lblAddFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddFirstname.Name = "lblAddFirstname";
            this.lblAddFirstname.Size = new System.Drawing.Size(55, 13);
            this.lblAddFirstname.TabIndex = 0;
            this.lblAddFirstname.Text = "First name";
            // 
            // tabPageDeleteStaff
            // 
            this.tabPageDeleteStaff.Controls.Add(this.btnDeleteStaff);
            this.tabPageDeleteStaff.Controls.Add(this.comboBoxDeleteStaffID);
            this.tabPageDeleteStaff.Controls.Add(this.lblStaffIDdelete);
            this.tabPageDeleteStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDeleteStaff.Name = "tabPageDeleteStaff";
            this.tabPageDeleteStaff.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDeleteStaff.Size = new System.Drawing.Size(373, 268);
            this.tabPageDeleteStaff.TabIndex = 1;
            this.tabPageDeleteStaff.Text = "Delete Waiter";
            this.tabPageDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(121, 206);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteStaff.TabIndex = 3;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDeleteStaffID
            // 
            this.comboBoxDeleteStaffID.FormattingEnabled = true;
            this.comboBoxDeleteStaffID.Location = new System.Drawing.Point(121, 103);
            this.comboBoxDeleteStaffID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDeleteStaffID.Name = "comboBoxDeleteStaffID";
            this.comboBoxDeleteStaffID.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDeleteStaffID.TabIndex = 2;
            this.comboBoxDeleteStaffID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteStaffID_SelectedIndexChanged);
            this.comboBoxDeleteStaffID.Click += new System.EventHandler(this.comboBoxDeleteStaffID_Click);
            // 
            // lblStaffIDdelete
            // 
            this.lblStaffIDdelete.AutoSize = true;
            this.lblStaffIDdelete.Location = new System.Drawing.Point(62, 103);
            this.lblStaffIDdelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffIDdelete.Name = "lblStaffIDdelete";
            this.lblStaffIDdelete.Size = new System.Drawing.Size(43, 13);
            this.lblStaffIDdelete.TabIndex = 1;
            this.lblStaffIDdelete.Text = "Staff ID";
            // 
            // tabPageUpStaff
            // 
            this.tabPageUpStaff.Controls.Add(this.btnUpStaff);
            this.tabPageUpStaff.Controls.Add(this.comboBoxStaffIDUP);
            this.tabPageUpStaff.Controls.Add(this.lblStaffUP);
            this.tabPageUpStaff.Controls.Add(this.textBoxPasswordUP);
            this.tabPageUpStaff.Controls.Add(this.textBoxUPusername);
            this.tabPageUpStaff.Controls.Add(this.textBoxUpLastname);
            this.tabPageUpStaff.Controls.Add(this.textBoxUPFirstName);
            this.tabPageUpStaff.Controls.Add(this.lblPasswordUP);
            this.tabPageUpStaff.Controls.Add(this.lblUPuasername);
            this.tabPageUpStaff.Controls.Add(this.lblUpLastname);
            this.tabPageUpStaff.Controls.Add(this.lblUPfirstname);
            this.tabPageUpStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUpStaff.Name = "tabPageUpStaff";
            this.tabPageUpStaff.Size = new System.Drawing.Size(373, 268);
            this.tabPageUpStaff.TabIndex = 2;
            this.tabPageUpStaff.Text = "Update Waiter";
            this.tabPageUpStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpStaff
            // 
            this.btnUpStaff.Location = new System.Drawing.Point(150, 234);
            this.btnUpStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpStaff.Name = "btnUpStaff";
            this.btnUpStaff.Size = new System.Drawing.Size(56, 19);
            this.btnUpStaff.TabIndex = 18;
            this.btnUpStaff.Text = "Update";
            this.btnUpStaff.UseVisualStyleBackColor = true;
            this.btnUpStaff.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxStaffIDUP
            // 
            this.comboBoxStaffIDUP.FormattingEnabled = true;
            this.comboBoxStaffIDUP.Location = new System.Drawing.Point(150, 61);
            this.comboBoxStaffIDUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStaffIDUP.Name = "comboBoxStaffIDUP";
            this.comboBoxStaffIDUP.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStaffIDUP.TabIndex = 17;
            this.comboBoxStaffIDUP.SelectedIndexChanged += new System.EventHandler(this.comboBoxStaffIDUP_SelectedIndexChanged);
            this.comboBoxStaffIDUP.Click += new System.EventHandler(this.comboBoxStaffIDUP_Click);
            // 
            // lblStaffUP
            // 
            this.lblStaffUP.AutoSize = true;
            this.lblStaffUP.Location = new System.Drawing.Point(92, 61);
            this.lblStaffUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffUP.Name = "lblStaffUP";
            this.lblStaffUP.Size = new System.Drawing.Size(43, 13);
            this.lblStaffUP.TabIndex = 16;
            this.lblStaffUP.Text = "Staff ID";
            this.lblStaffUP.Click += new System.EventHandler(this.lblStaffUP_Click);
            // 
            // textBoxPasswordUP
            // 
            this.textBoxPasswordUP.Location = new System.Drawing.Point(150, 193);
            this.textBoxPasswordUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswordUP.Name = "textBoxPasswordUP";
            this.textBoxPasswordUP.Size = new System.Drawing.Size(76, 20);
            this.textBoxPasswordUP.TabIndex = 15;
            // 
            // textBoxUPusername
            // 
            this.textBoxUPusername.Location = new System.Drawing.Point(150, 158);
            this.textBoxUPusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUPusername.Name = "textBoxUPusername";
            this.textBoxUPusername.Size = new System.Drawing.Size(76, 20);
            this.textBoxUPusername.TabIndex = 14;
            // 
            // textBoxUpLastname
            // 
            this.textBoxUpLastname.Location = new System.Drawing.Point(150, 124);
            this.textBoxUpLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpLastname.Name = "textBoxUpLastname";
            this.textBoxUpLastname.Size = new System.Drawing.Size(76, 20);
            this.textBoxUpLastname.TabIndex = 13;
            // 
            // textBoxUPFirstName
            // 
            this.textBoxUPFirstName.Location = new System.Drawing.Point(150, 93);
            this.textBoxUPFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUPFirstName.Name = "textBoxUPFirstName";
            this.textBoxUPFirstName.Size = new System.Drawing.Size(76, 20);
            this.textBoxUPFirstName.TabIndex = 12;
            // 
            // lblPasswordUP
            // 
            this.lblPasswordUP.AutoSize = true;
            this.lblPasswordUP.Location = new System.Drawing.Point(97, 195);
            this.lblPasswordUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordUP.Name = "lblPasswordUP";
            this.lblPasswordUP.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordUP.TabIndex = 11;
            this.lblPasswordUP.Text = "Password";
            // 
            // lblUPuasername
            // 
            this.lblUPuasername.AutoSize = true;
            this.lblUPuasername.Location = new System.Drawing.Point(94, 162);
            this.lblUPuasername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUPuasername.Name = "lblUPuasername";
            this.lblUPuasername.Size = new System.Drawing.Size(55, 13);
            this.lblUPuasername.TabIndex = 10;
            this.lblUPuasername.Text = "Username";
            // 
            // lblUpLastname
            // 
            this.lblUpLastname.AutoSize = true;
            this.lblUpLastname.Location = new System.Drawing.Point(92, 128);
            this.lblUpLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpLastname.Name = "lblUpLastname";
            this.lblUpLastname.Size = new System.Drawing.Size(53, 13);
            this.lblUpLastname.TabIndex = 9;
            this.lblUpLastname.Text = "Lastname";
            // 
            // lblUPfirstname
            // 
            this.lblUPfirstname.AutoSize = true;
            this.lblUPfirstname.Location = new System.Drawing.Point(90, 97);
            this.lblUPfirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUPfirstname.Name = "lblUPfirstname";
            this.lblUPfirstname.Size = new System.Drawing.Size(55, 13);
            this.lblUPfirstname.TabIndex = 8;
            this.lblUPfirstname.Text = "First name";
            // 
            // lblStaffHeading
            // 
            this.lblStaffHeading.AutoSize = true;
            this.lblStaffHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffHeading.Location = new System.Drawing.Point(257, 19);
            this.lblStaffHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffHeading.Name = "lblStaffHeading";
            this.lblStaffHeading.Size = new System.Drawing.Size(94, 29);
            this.lblStaffHeading.TabIndex = 2;
            this.lblStaffHeading.Text = "Waiters";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblStaffHeading);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddStaff.ResumeLayout(false);
            this.tabPageAddStaff.PerformLayout();
            this.tabPageDeleteStaff.ResumeLayout(false);
            this.tabPageDeleteStaff.PerformLayout();
            this.tabPageUpStaff.ResumeLayout(false);
            this.tabPageUpStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddStaff;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.TextBox textBoxAddUsername;
        private System.Windows.Forms.TextBox textBoxAddLastname;
        private System.Windows.Forms.TextBox textBoxAddFirstname;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.Label lblAddUsername;
        private System.Windows.Forms.Label lblAddLastname;
        private System.Windows.Forms.Label lblAddFirstname;
        private System.Windows.Forms.TabPage tabPageDeleteStaff;
        private System.Windows.Forms.ComboBox comboBoxDeleteStaffID;
        private System.Windows.Forms.Label lblStaffIDdelete;
        private System.Windows.Forms.TabPage tabPageUpStaff;
        private System.Windows.Forms.ComboBox comboBoxStaffIDUP;
        private System.Windows.Forms.Label lblStaffUP;
        private System.Windows.Forms.TextBox textBoxPasswordUP;
        private System.Windows.Forms.TextBox textBoxUPusername;
        private System.Windows.Forms.TextBox textBoxUpLastname;
        private System.Windows.Forms.TextBox textBoxUPFirstName;
        private System.Windows.Forms.Label lblPasswordUP;
        private System.Windows.Forms.Label lblUPuasername;
        private System.Windows.Forms.Label lblUpLastname;
        private System.Windows.Forms.Label lblUPfirstname;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpStaff;
        private System.Windows.Forms.Label lblStaffHeading;
    }
}