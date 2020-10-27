namespace Desktop
{
    partial class Orders
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.comboBoxDeleteOrderID = new System.Windows.Forms.ComboBox();
            this.lblOrderDeleteID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.btnConfirmUP = new System.Windows.Forms.Button();
            this.comboBoxCashorCard = new System.Windows.Forms.ComboBox();
            this.comboBoxPaid = new System.Windows.Forms.ComboBox();
            this.textBoxWaiter = new System.Windows.Forms.TextBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblCashorCard = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfirmDelete);
            this.tabPage1.Controls.Add(this.comboBoxDeleteOrderID);
            this.tabPage1.Controls.Add(this.lblOrderDeleteID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Delete Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(355, 348);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmDelete.TabIndex = 5;
            this.btnConfirmDelete.Text = "Confirm";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // comboBoxDeleteOrderID
            // 
            this.comboBoxDeleteOrderID.FormattingEnabled = true;
            this.comboBoxDeleteOrderID.Location = new System.Drawing.Point(355, 206);
            this.comboBoxDeleteOrderID.Name = "comboBoxDeleteOrderID";
            this.comboBoxDeleteOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteOrderID.TabIndex = 3;
            this.comboBoxDeleteOrderID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteOrderID_SelectedIndexChanged);
            this.comboBoxDeleteOrderID.Click += new System.EventHandler(this.comboBoxDeleteOrderID_Click);
            // 
            // lblOrderDeleteID
            // 
            this.lblOrderDeleteID.AutoSize = true;
            this.lblOrderDeleteID.Location = new System.Drawing.Point(163, 209);
            this.lblOrderDeleteID.Name = "lblOrderDeleteID";
            this.lblOrderDeleteID.Size = new System.Drawing.Size(164, 17);
            this.lblOrderDeleteID.TabIndex = 0;
            this.lblOrderDeleteID.Text = "Delete order by Order ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxStatus);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.textBoxQuant);
            this.tabPage2.Controls.Add(this.lblQuant);
            this.tabPage2.Controls.Add(this.btnConfirmUP);
            this.tabPage2.Controls.Add(this.comboBoxCashorCard);
            this.tabPage2.Controls.Add(this.comboBoxPaid);
            this.tabPage2.Controls.Add(this.textBoxWaiter);
            this.tabPage2.Controls.Add(this.textBoxTable);
            this.tabPage2.Controls.Add(this.dateTimePickerOrder);
            this.tabPage2.Controls.Add(this.comboBoxOrderID);
            this.tabPage2.Controls.Add(this.lblTable);
            this.tabPage2.Controls.Add(this.lblWaiter);
            this.tabPage2.Controls.Add(this.lblPaid);
            this.tabPage2.Controls.Add(this.lblCashorCard);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.lblOrderID);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(450, 252);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuant.TabIndex = 17;
            this.textBoxQuant.TextChanged += new System.EventHandler(this.textBoxQuant_TextChanged);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(360, 252);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(61, 17);
            this.lblQuant.TabIndex = 15;
            this.lblQuant.Text = "Quantity";
            this.lblQuant.Click += new System.EventHandler(this.lblQuant_Click);
            // 
            // btnConfirmUP
            // 
            this.btnConfirmUP.Location = new System.Drawing.Point(123, 399);
            this.btnConfirmUP.Name = "btnConfirmUP";
            this.btnConfirmUP.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmUP.TabIndex = 13;
            this.btnConfirmUP.Text = "Confirm";
            this.btnConfirmUP.UseVisualStyleBackColor = true;
            this.btnConfirmUP.Click += new System.EventHandler(this.btnConfirmUP_Click);
            // 
            // comboBoxCashorCard
            // 
            this.comboBoxCashorCard.FormattingEnabled = true;
            this.comboBoxCashorCard.Location = new System.Drawing.Point(449, 187);
            this.comboBoxCashorCard.Name = "comboBoxCashorCard";
            this.comboBoxCashorCard.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCashorCard.TabIndex = 12;
            this.comboBoxCashorCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCashorCard_SelectedIndexChanged);
            this.comboBoxCashorCard.Click += new System.EventHandler(this.comboBoxCashorCard_Click);
            // 
            // comboBoxPaid
            // 
            this.comboBoxPaid.FormattingEnabled = true;
            this.comboBoxPaid.Location = new System.Drawing.Point(122, 184);
            this.comboBoxPaid.Name = "comboBoxPaid";
            this.comboBoxPaid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaid.TabIndex = 11;
            this.comboBoxPaid.Click += new System.EventHandler(this.comboBoxPaid_Click);
            // 
            // textBoxWaiter
            // 
            this.textBoxWaiter.Location = new System.Drawing.Point(449, 113);
            this.textBoxWaiter.Name = "textBoxWaiter";
            this.textBoxWaiter.Size = new System.Drawing.Size(100, 22);
            this.textBoxWaiter.TabIndex = 10;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(123, 113);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 22);
            this.textBoxTable.TabIndex = 9;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(449, 54);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOrder.TabIndex = 8;
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(122, 47);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderID.TabIndex = 7;
            this.comboBoxOrderID.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderID_SelectedIndexChanged);
            this.comboBoxOrderID.Click += new System.EventHandler(this.comboBoxOrderID_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(21, 113);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(96, 17);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table number";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Location = new System.Drawing.Point(360, 116);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(66, 17);
            this.lblWaiter.TabIndex = 4;
            this.lblWaiter.Text = "Waiter ID";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(42, 187);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 17);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "Paid staus";
            // 
            // lblCashorCard
            // 
            this.lblCashorCard.AutoSize = true;
            this.lblCashorCard.Location = new System.Drawing.Point(353, 187);
            this.lblCashorCard.Name = "lblCashorCard";
            this.lblCashorCard.Size = new System.Drawing.Size(89, 17);
            this.lblCashorCard.TabIndex = 2;
            this.lblCashorCard.Text = "Card or cash";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(342, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date and Time";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(33, 47);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(62, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 502);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(45, 262);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxStatus.Location = new System.Drawing.Point(123, 253);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 503);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxDeleteOrderID;
        private System.Windows.Forms.Label lblOrderDeleteID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxCashorCard;
        private System.Windows.Forms.ComboBox comboBoxPaid;
        private System.Windows.Forms.TextBox textBoxWaiter;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.ComboBox comboBoxOrderID;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblCashorCard;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Button btnConfirmUP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}