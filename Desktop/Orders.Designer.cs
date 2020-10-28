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
            this.tabPageDeleteOrder = new System.Windows.Forms.TabPage();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.comboBoxDeleteOrderID = new System.Windows.Forms.ComboBox();
            this.lblOrderDeleteID = new System.Windows.Forms.Label();
            this.tabPageUpOrders = new System.Windows.Forms.TabPage();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.lblOrderHeading = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDeleteOrder.SuspendLayout();
            this.tabPageUpOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeleteOrder);
            this.tabControl1.Controls.Add(this.tabPageUpOrders);
            this.tabControl1.Location = new System.Drawing.Point(70, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDeleteOrder
            // 
            this.tabPageDeleteOrder.Controls.Add(this.btnConfirmDelete);
            this.tabPageDeleteOrder.Controls.Add(this.comboBoxDeleteOrderID);
            this.tabPageDeleteOrder.Controls.Add(this.lblOrderDeleteID);
            this.tabPageDeleteOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeleteOrder.Name = "tabPageDeleteOrder";
            this.tabPageDeleteOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteOrder.Size = new System.Drawing.Size(699, 436);
            this.tabPageDeleteOrder.TabIndex = 0;
            this.tabPageDeleteOrder.Text = "Delete Order";
            this.tabPageDeleteOrder.UseVisualStyleBackColor = true;
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
            // tabPageUpOrders
            // 
            this.tabPageUpOrders.Controls.Add(this.comboBoxStatus);
            this.tabPageUpOrders.Controls.Add(this.lblStatus);
            this.tabPageUpOrders.Controls.Add(this.textBoxQuant);
            this.tabPageUpOrders.Controls.Add(this.lblQuant);
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
            this.tabPageUpOrders.Size = new System.Drawing.Size(686, 413);
            this.tabPageUpOrders.TabIndex = 1;
            this.tabPageUpOrders.Text = "Update Orders";
            this.tabPageUpOrders.UseVisualStyleBackColor = true;
            this.tabPageUpOrders.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxStatus.Location = new System.Drawing.Point(124, 275);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(46, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(460, 267);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuant.TabIndex = 17;
            this.textBoxQuant.TextChanged += new System.EventHandler(this.textBoxQuant_TextChanged);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(370, 267);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(61, 17);
            this.lblQuant.TabIndex = 15;
            this.lblQuant.Text = "Quantity";
            this.lblQuant.Click += new System.EventHandler(this.lblQuant_Click);
            // 
            // btnConfirmUP
            // 
            this.btnConfirmUP.Location = new System.Drawing.Point(123, 359);
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
            this.comboBoxCashorCard.Location = new System.Drawing.Point(459, 202);
            this.comboBoxCashorCard.Name = "comboBoxCashorCard";
            this.comboBoxCashorCard.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCashorCard.TabIndex = 12;
            this.comboBoxCashorCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCashorCard_SelectedIndexChanged);
            this.comboBoxCashorCard.Click += new System.EventHandler(this.comboBoxCashorCard_Click);
            // 
            // comboBoxPaid
            // 
            this.comboBoxPaid.FormattingEnabled = true;
            this.comboBoxPaid.Location = new System.Drawing.Point(123, 206);
            this.comboBoxPaid.Name = "comboBoxPaid";
            this.comboBoxPaid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaid.TabIndex = 11;
            this.comboBoxPaid.Click += new System.EventHandler(this.comboBoxPaid_Click);
            // 
            // textBoxWaiter
            // 
            this.textBoxWaiter.Location = new System.Drawing.Point(459, 128);
            this.textBoxWaiter.Name = "textBoxWaiter";
            this.textBoxWaiter.Size = new System.Drawing.Size(100, 22);
            this.textBoxWaiter.TabIndex = 10;
            this.textBoxWaiter.TextChanged += new System.EventHandler(this.textBoxWaiter_TextChanged);
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(124, 135);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 22);
            this.textBoxTable.TabIndex = 9;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(459, 69);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOrder.TabIndex = 8;
            this.dateTimePickerOrder.ValueChanged += new System.EventHandler(this.dateTimePickerOrder_ValueChanged);
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(123, 69);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderID.TabIndex = 7;
            this.comboBoxOrderID.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderID_SelectedIndexChanged);
            this.comboBoxOrderID.Click += new System.EventHandler(this.comboBoxOrderID_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(22, 135);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(96, 17);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table number";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Location = new System.Drawing.Point(370, 131);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(66, 17);
            this.lblWaiter.TabIndex = 4;
            this.lblWaiter.Text = "Waiter ID";
            this.lblWaiter.Click += new System.EventHandler(this.lblWaiter_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(43, 209);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 17);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "Paid staus";
            // 
            // lblCashorCard
            // 
            this.lblCashorCard.AutoSize = true;
            this.lblCashorCard.Location = new System.Drawing.Point(363, 202);
            this.lblCashorCard.Name = "lblCashorCard";
            this.lblCashorCard.Size = new System.Drawing.Size(89, 17);
            this.lblCashorCard.TabIndex = 2;
            this.lblCashorCard.Text = "Card or cash";
            this.lblCashorCard.Click += new System.EventHandler(this.lblCashorCard_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(352, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date and Time";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(34, 69);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(62, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblOrderHeading
            // 
            this.lblOrderHeading.AutoSize = true;
            this.lblOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHeading.Location = new System.Drawing.Point(383, 48);
            this.lblOrderHeading.Name = "lblOrderHeading";
            this.lblOrderHeading.Size = new System.Drawing.Size(105, 36);
            this.lblOrderHeading.TabIndex = 2;
            this.lblOrderHeading.Text = "Orders";
            this.lblOrderHeading.Click += new System.EventHandler(this.lblOrderHeading_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 552);
            this.Controls.Add(this.lblOrderHeading);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDeleteOrder.ResumeLayout(false);
            this.tabPageDeleteOrder.PerformLayout();
            this.tabPageUpOrders.ResumeLayout(false);
            this.tabPageUpOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDeleteOrder;
        private System.Windows.Forms.ComboBox comboBoxDeleteOrderID;
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
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderHeading;
    }
}