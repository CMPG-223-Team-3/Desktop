namespace Manager
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblOrderDeleteID = new System.Windows.Forms.Label();
            this.lblDeletetableOrders = new System.Windows.Forms.Label();
            this.comboBoxDeleteOrderID = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteTable = new System.Windows.Forms.ComboBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCashorCard = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.textBoxWaiter = new System.Windows.Forms.TextBox();
            this.comboBoxPaid = new System.Windows.Forms.ComboBox();
            this.comboBoxCashorCard = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(210, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxDeleteTable);
            this.tabPage1.Controls.Add(this.comboBoxDeleteOrderID);
            this.tabPage1.Controls.Add(this.lblDeletetableOrders);
            this.tabPage1.Controls.Add(this.lblOrderDeleteID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(485, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblDeletetableOrders
            // 
            this.lblDeletetableOrders.AutoSize = true;
            this.lblDeletetableOrders.Location = new System.Drawing.Point(66, 160);
            this.lblDeletetableOrders.Name = "lblDeletetableOrders";
            this.lblDeletetableOrders.Size = new System.Drawing.Size(141, 17);
            this.lblDeletetableOrders.TabIndex = 1;
            this.lblDeletetableOrders.Text = "Delete Tables orders";
            // 
            // comboBoxDeleteOrderID
            // 
            this.comboBoxDeleteOrderID.FormattingEnabled = true;
            this.comboBoxDeleteOrderID.Location = new System.Drawing.Point(255, 100);
            this.comboBoxDeleteOrderID.Name = "comboBoxDeleteOrderID";
            this.comboBoxDeleteOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteOrderID.TabIndex = 3;
            // 
            // comboBoxDeleteTable
            // 
            this.comboBoxDeleteTable.FormattingEnabled = true;
            this.comboBoxDeleteTable.Location = new System.Drawing.Point(255, 157);
            this.comboBoxDeleteTable.Name = "comboBoxDeleteTable";
            this.comboBoxDeleteTable.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteTable.TabIndex = 4;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date and Time";
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
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(42, 309);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 17);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "Paid staus";
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
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(20, 174);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(96, 17);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table number";
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(122, 47);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderID.TabIndex = 7;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(122, 97);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOrder.TabIndex = 8;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(122, 174);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 22);
            this.textBoxTable.TabIndex = 9;
            // 
            // textBoxWaiter
            // 
            this.textBoxWaiter.Location = new System.Drawing.Point(122, 242);
            this.textBoxWaiter.Name = "textBoxWaiter";
            this.textBoxWaiter.Size = new System.Drawing.Size(100, 22);
            this.textBoxWaiter.TabIndex = 10;
            // 
            // comboBoxPaid
            // 
            this.comboBoxPaid.FormattingEnabled = true;
            this.comboBoxPaid.Location = new System.Drawing.Point(122, 306);
            this.comboBoxPaid.Name = "comboBoxPaid";
            this.comboBoxPaid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaid.TabIndex = 11;
            // 
            // comboBoxCashorCard
            // 
            this.comboBoxCashorCard.FormattingEnabled = true;
            this.comboBoxCashorCard.Location = new System.Drawing.Point(123, 344);
            this.comboBoxCashorCard.Name = "comboBoxCashorCard";
            this.comboBoxCashorCard.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCashorCard.TabIndex = 12;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 503);
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

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxDeleteTable;
        private System.Windows.Forms.ComboBox comboBoxDeleteOrderID;
        private System.Windows.Forms.Label lblDeletetableOrders;
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
    }
}