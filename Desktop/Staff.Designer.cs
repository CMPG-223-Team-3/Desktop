﻿namespace Desktop
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.btnUpdateStaff = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.tabPageAddStaff.SuspendLayout();
            this.tabPageDeleteStaff.SuspendLayout();
            this.tabPageUpStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddStaff);
            this.tabControl1.Controls.Add(this.tabPageDeleteStaff);
            this.tabControl1.Controls.Add(this.tabPageUpStaff);
            this.tabControl1.Location = new System.Drawing.Point(58, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 362);
            this.tabControl1.TabIndex = 0;
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
            this.tabPageAddStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddStaff.Name = "tabPageAddStaff";
            this.tabPageAddStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStaff.Size = new System.Drawing.Size(500, 333);
            this.tabPageAddStaff.TabIndex = 0;
            this.tabPageAddStaff.Text = "Add Staff member ";
            this.tabPageAddStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(121, 238);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.Location = new System.Drawing.Point(121, 174);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddPassword.TabIndex = 7;
            // 
            // textBoxAddUsername
            // 
            this.textBoxAddUsername.Location = new System.Drawing.Point(121, 131);
            this.textBoxAddUsername.Name = "textBoxAddUsername";
            this.textBoxAddUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddUsername.TabIndex = 6;
            // 
            // textBoxAddLastname
            // 
            this.textBoxAddLastname.Location = new System.Drawing.Point(121, 89);
            this.textBoxAddLastname.Name = "textBoxAddLastname";
            this.textBoxAddLastname.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddLastname.TabIndex = 5;
            // 
            // textBoxAddFirstname
            // 
            this.textBoxAddFirstname.Location = new System.Drawing.Point(121, 51);
            this.textBoxAddFirstname.Name = "textBoxAddFirstname";
            this.textBoxAddFirstname.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddFirstname.TabIndex = 4;
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Location = new System.Drawing.Point(50, 177);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(69, 17);
            this.lblAddPassword.TabIndex = 3;
            this.lblAddPassword.Text = "Password";
            // 
            // lblAddUsername
            // 
            this.lblAddUsername.AutoSize = true;
            this.lblAddUsername.Location = new System.Drawing.Point(47, 136);
            this.lblAddUsername.Name = "lblAddUsername";
            this.lblAddUsername.Size = new System.Drawing.Size(73, 17);
            this.lblAddUsername.TabIndex = 2;
            this.lblAddUsername.Text = "Username";
            // 
            // lblAddLastname
            // 
            this.lblAddLastname.AutoSize = true;
            this.lblAddLastname.Location = new System.Drawing.Point(44, 94);
            this.lblAddLastname.Name = "lblAddLastname";
            this.lblAddLastname.Size = new System.Drawing.Size(70, 17);
            this.lblAddLastname.TabIndex = 1;
            this.lblAddLastname.Text = "Lastname";
            // 
            // lblAddFirstname
            // 
            this.lblAddFirstname.AutoSize = true;
            this.lblAddFirstname.Location = new System.Drawing.Point(41, 56);
            this.lblAddFirstname.Name = "lblAddFirstname";
            this.lblAddFirstname.Size = new System.Drawing.Size(74, 17);
            this.lblAddFirstname.TabIndex = 0;
            this.lblAddFirstname.Text = "First name";
            // 
            // tabPageDeleteStaff
            // 
            this.tabPageDeleteStaff.Controls.Add(this.btnDeleteStaff);
            this.tabPageDeleteStaff.Controls.Add(this.comboBoxDeleteStaffID);
            this.tabPageDeleteStaff.Controls.Add(this.lblStaffIDdelete);
            this.tabPageDeleteStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeleteStaff.Name = "tabPageDeleteStaff";
            this.tabPageDeleteStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteStaff.Size = new System.Drawing.Size(500, 333);
            this.tabPageDeleteStaff.TabIndex = 1;
            this.tabPageDeleteStaff.Text = "Delete staff member";
            this.tabPageDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(161, 254);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 3;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDeleteStaffID
            // 
            this.comboBoxDeleteStaffID.FormattingEnabled = true;
            this.comboBoxDeleteStaffID.Location = new System.Drawing.Point(161, 127);
            this.comboBoxDeleteStaffID.Name = "comboBoxDeleteStaffID";
            this.comboBoxDeleteStaffID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteStaffID.TabIndex = 2;
            this.comboBoxDeleteStaffID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteStaffID_SelectedIndexChanged);
            this.comboBoxDeleteStaffID.Click += new System.EventHandler(this.comboBoxDeleteStaffID_Click);
            // 
            // lblStaffIDdelete
            // 
            this.lblStaffIDdelete.AutoSize = true;
            this.lblStaffIDdelete.Location = new System.Drawing.Point(83, 127);
            this.lblStaffIDdelete.Name = "lblStaffIDdelete";
            this.lblStaffIDdelete.Size = new System.Drawing.Size(54, 17);
            this.lblStaffIDdelete.TabIndex = 1;
            this.lblStaffIDdelete.Text = "Staff ID";
            // 
            // tabPageUpStaff
            // 
            this.tabPageUpStaff.Controls.Add(this.btnUpdateStaff);
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
            this.tabPageUpStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageUpStaff.Name = "tabPageUpStaff";
            this.tabPageUpStaff.Size = new System.Drawing.Size(500, 333);
            this.tabPageUpStaff.TabIndex = 2;
            this.tabPageUpStaff.Text = "Update staff member";
            this.tabPageUpStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(138, 262);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStaff.TabIndex = 18;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxStaffIDUP
            // 
            this.comboBoxStaffIDUP.FormattingEnabled = true;
            this.comboBoxStaffIDUP.Location = new System.Drawing.Point(138, 49);
            this.comboBoxStaffIDUP.Name = "comboBoxStaffIDUP";
            this.comboBoxStaffIDUP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStaffIDUP.TabIndex = 17;
            this.comboBoxStaffIDUP.Click += new System.EventHandler(this.comboBoxStaffIDUP_Click);
            // 
            // lblStaffUP
            // 
            this.lblStaffUP.AutoSize = true;
            this.lblStaffUP.Location = new System.Drawing.Point(61, 49);
            this.lblStaffUP.Name = "lblStaffUP";
            this.lblStaffUP.Size = new System.Drawing.Size(54, 17);
            this.lblStaffUP.TabIndex = 16;
            this.lblStaffUP.Text = "Staff ID";
            // 
            // textBoxPasswordUP
            // 
            this.textBoxPasswordUP.Location = new System.Drawing.Point(138, 211);
            this.textBoxPasswordUP.Name = "textBoxPasswordUP";
            this.textBoxPasswordUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxPasswordUP.TabIndex = 15;
            // 
            // textBoxUPusername
            // 
            this.textBoxUPusername.Location = new System.Drawing.Point(138, 168);
            this.textBoxUPusername.Name = "textBoxUPusername";
            this.textBoxUPusername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUPusername.TabIndex = 14;
            // 
            // textBoxUpLastname
            // 
            this.textBoxUpLastname.Location = new System.Drawing.Point(138, 126);
            this.textBoxUpLastname.Name = "textBoxUpLastname";
            this.textBoxUpLastname.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpLastname.TabIndex = 13;
            // 
            // textBoxUPFirstName
            // 
            this.textBoxUPFirstName.Location = new System.Drawing.Point(138, 88);
            this.textBoxUPFirstName.Name = "textBoxUPFirstName";
            this.textBoxUPFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUPFirstName.TabIndex = 12;
            // 
            // lblPasswordUP
            // 
            this.lblPasswordUP.AutoSize = true;
            this.lblPasswordUP.Location = new System.Drawing.Point(67, 214);
            this.lblPasswordUP.Name = "lblPasswordUP";
            this.lblPasswordUP.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordUP.TabIndex = 11;
            this.lblPasswordUP.Text = "Password";
            // 
            // lblUPuasername
            // 
            this.lblUPuasername.AutoSize = true;
            this.lblUPuasername.Location = new System.Drawing.Point(64, 173);
            this.lblUPuasername.Name = "lblUPuasername";
            this.lblUPuasername.Size = new System.Drawing.Size(73, 17);
            this.lblUPuasername.TabIndex = 10;
            this.lblUPuasername.Text = "Username";
            // 
            // lblUpLastname
            // 
            this.lblUpLastname.AutoSize = true;
            this.lblUpLastname.Location = new System.Drawing.Point(61, 131);
            this.lblUpLastname.Name = "lblUpLastname";
            this.lblUpLastname.Size = new System.Drawing.Size(70, 17);
            this.lblUpLastname.TabIndex = 9;
            this.lblUpLastname.Text = "Lastname";
            // 
            // lblUPfirstname
            // 
            this.lblUPfirstname.AutoSize = true;
            this.lblUPfirstname.Location = new System.Drawing.Point(58, 93);
            this.lblUPfirstname.Name = "lblUPfirstname";
            this.lblUPfirstname.Size = new System.Drawing.Size(74, 17);
            this.lblUPfirstname.TabIndex = 8;
            this.lblUPfirstname.Text = "First name";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddStaff.ResumeLayout(false);
            this.tabPageAddStaff.PerformLayout();
            this.tabPageDeleteStaff.ResumeLayout(false);
            this.tabPageDeleteStaff.PerformLayout();
            this.tabPageUpStaff.ResumeLayout(false);
            this.tabPageUpStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Button btnUpdateStaff;
    }
}