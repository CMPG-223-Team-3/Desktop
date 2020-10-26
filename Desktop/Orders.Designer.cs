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
            this.tabPageDeleteOrders = new System.Windows.Forms.TabPage();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.comboBoxDeleteTable = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteOrderID = new System.Windows.Forms.ComboBox();
            this.lblDeletetableOrders = new System.Windows.Forms.Label();
            this.lblOrderDeleteID = new System.Windows.Forms.Label();
            this.tabPageUpOrders = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPageDeleteOrders.SuspendLayout();
            this.tabPageUpOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeleteOrders);
            this.tabControl1.Controls.Add(this.tabPageUpOrders);
            this.tabControl1.Location = new System.Drawing.Point(210, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDeleteOrders
            // 
            this.tabPageDeleteOrders.Controls.Add(this.btnConfirmDelete);
            this.tabPageDeleteOrders.Controls.Add(this.comboBoxDeleteTable);
            this.tabPageDeleteOrders.Controls.Add(this.comboBoxDeleteOrderID);
            this.tabPageDeleteOrders.Controls.Add(this.lblDeletetableOrders);
            this.tabPageDeleteOrders.Controls.Add(this.lblOrderDeleteID);
            this.tabPageDeleteOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeleteOrders.Name = "tabPageDeleteOrders";
            this.tabPageDeleteOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteOrders.Size = new System.Drawing.Size(485, 436);
            this.tabPageDeleteOrders.TabIndex = 0;
            this.tabPageDeleteOrders.Text = "Delete Order";
            this.tabPageDeleteOrders.UseVisualStyleBackColor = true;
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(66, 266);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmDelete.TabIndex = 5;
            this.btnConfirmDelete.Text = "Confirm";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // comboBoxDeleteTable
            // 
            this.comboBoxDeleteTable.FormattingEnabled = true;
            this.comboBoxDeleteTable.Location = new System.Drawing.Point(255, 157);
            this.comboBoxDeleteTable.Name = "comboBoxDeleteTable";
            this.comboBoxDeleteTable.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteTable.TabIndex = 4;
            this.comboBoxDeleteTable.Click += new System.EventHandler(this.comboBoxDeleteTable_Click);
            // 
            // comboBoxDeleteOrderID
            // 
            this.comboBoxDeleteOrderID.FormattingEnabled = true;
            this.comboBoxDeleteOrderID.Location = new System.Drawing.Point(255, 100);
            this.comboBoxDeleteOrderID.Name = "comboBoxDeleteOrderID";
            this.comboBoxDeleteOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteOrderID.TabIndex = 3;
            this.comboBoxDeleteOrderID.Click += new System.EventHandler(this.comboBoxDeleteOrderID_Click);
            // 
            // lblDeletetableOrders
            // 
            this.lblDeletetableOrders.AutoSize = true;
            this.lblDeletetableOrders.Location = new System.Drawing.Point(66, 160);
            this.lblDeletetableOrders.Name = "lblDeletetableOrders";
            this.lblDeletetableOrders.Size = new System.Drawing.Size(141, 17);
            this.lblDeletetableOrders.TabIndex = 1;
            this.lblDeletetableOrders.Text = "Delete Tables orders";
            // 
            // lblOrderDeleteID
            // 
            this.lblOrderDeleteID.AutoSize = true;
            this.lblOrderDeleteID.Location = new System.Drawing.Point(63, 103);
            this.lblOrderDeleteID.Name = "lblOrderDeleteID";
            this.lblOrderDeleteID.Size = new System.Drawing.Size(164, 17);
            this.lblOrderDeleteID.TabIndex = 0;
            this.lblOrderDeleteID.Text = "Delete order by Order ID";
            // 
            // tabPageUpOrders
            // 
            this.tabPageUpOrders.Controls.Add(this.btnConfirmUP);
            this.tabPageUpOrders.Controls.Add(this.comboBoxCashorCard);
            this.tabPageUpOrders.Controls.Add(this.comboBoxPaid);
            this.tabPageUpOrders.Controls.Add(this.textBoxWaiter);
            this.tabPageUpOrders.Controls.Add(this.textBoxTable);
            this.tabPageUpOrders.Controls.Add(this.dateTimePickerOrder);
            this.tabPageUpOrders.Controls.Add(this.comboBoxOrderID);
            this.tabPageUpOrders.Controls.Add(this.lblTable);
            this.tabPageUpOrders.Controls.Add(this.lblWaiter);
            this.tabPageUpOrders.Controls.Add(this.lblPaid);
            this.tabPageUpOrders.Controls.Add(this.lblCashorCard);
            this.tabPageUpOrders.Controls.Add(this.lblDate);
            this.tabPageUpOrders.Controls.Add(this.lblOrderID);
            this.tabPageUpOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageUpOrders.Name = "tabPageUpOrders";
            this.tabPageUpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpOrders.Size = new System.Drawing.Size(485, 436);
            this.tabPageUpOrders.TabIndex = 1;
            this.tabPageUpOrders.Text = "Update Orders";
            this.tabPageUpOrders.UseVisualStyleBackColor = true;
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
            this.comboBoxCashorCard.Location = new System.Drawing.Point(123, 344);
            this.comboBoxCashorCard.Name = "comboBoxCashorCard";
            this.comboBoxCashorCard.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCashorCard.TabIndex = 12;
            this.comboBoxCashorCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCashorCard_SelectedIndexChanged);
            this.comboBoxCashorCard.Click += new System.EventHandler(this.comboBoxCashorCard_Click);
            // 
            // comboBoxPaid
            // 
            this.comboBoxPaid.FormattingEnabled = true;
            this.comboBoxPaid.Location = new System.Drawing.Point(122, 306);
            this.comboBoxPaid.Name = "comboBoxPaid";
            this.comboBoxPaid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaid.TabIndex = 11;
            this.comboBoxPaid.Click += new System.EventHandler(this.comboBoxPaid_Click);
            // 
            // textBoxWaiter
            // 
            this.textBoxWaiter.Location = new System.Drawing.Point(122, 242);
            this.textBoxWaiter.Name = "textBoxWaiter";
            this.textBoxWaiter.Size = new System.Drawing.Size(100, 22);
            this.textBoxWaiter.TabIndex = 10;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(122, 174);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 22);
            this.textBoxTable.TabIndex = 9;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(122, 97);
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
            this.lblTable.Location = new System.Drawing.Point(20, 174);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(96, 17);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table number";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Location = new System.Drawing.Point(33, 245);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(66, 17);
            this.lblWaiter.TabIndex = 4;
            this.lblWaiter.Text = "Waiter ID";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(42, 309);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 17);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "Paid staus";
            // 
            // lblCashorCard
            // 
            this.lblCashorCard.AutoSize = true;
            this.lblCashorCard.Location = new System.Drawing.Point(27, 344);
            this.lblCashorCard.Name = "lblCashorCard";
            this.lblCashorCard.Size = new System.Drawing.Size(89, 17);
            this.lblCashorCard.TabIndex = 2;
            this.lblCashorCard.Text = "Card or cash";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 97);
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
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDeleteOrders.ResumeLayout(false);
            this.tabPageDeleteOrders.PerformLayout();
            this.tabPageUpOrders.ResumeLayout(false);
            this.tabPageUpOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDeleteOrders;
        private System.Windows.Forms.ComboBox comboBoxDeleteTable;
        private System.Windows.Forms.ComboBox comboBoxDeleteOrderID;
        private System.Windows.Forms.Label lblDeletetableOrders;
        private System.Windows.Forms.Label lblOrderDeleteID;
        private System.Windows.Forms.TabPage tabPageUpOrders;
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
    }
}