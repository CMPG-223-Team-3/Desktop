namespace Desktop
{
    partial class Reports
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
            this.listBoxTop10 = new System.Windows.Forms.ListBox();
            this.dateTimePickerBeginOrders = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndOrders = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginTop10 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTopt10 = new System.Windows.Forms.DateTimePicker();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTop10 = new System.Windows.Forms.Label();
            this.btnOrderRep = new System.Windows.Forms.Button();
            this.btnTop10Rep = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.lblReportsHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTop10
            // 
            this.listBoxTop10.FormattingEnabled = true;
            this.listBoxTop10.Location = new System.Drawing.Point(536, 185);
            this.listBoxTop10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTop10.Name = "listBoxTop10";
            this.listBoxTop10.Size = new System.Drawing.Size(146, 225);
            this.listBoxTop10.TabIndex = 1;
            this.listBoxTop10.SelectedIndexChanged += new System.EventHandler(this.listBoxTop10_SelectedIndexChanged);
            // 
            // dateTimePickerBeginOrders
            // 
            this.dateTimePickerBeginOrders.Location = new System.Drawing.Point(11, 90);
            this.dateTimePickerBeginOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerBeginOrders.Name = "dateTimePickerBeginOrders";
            this.dateTimePickerBeginOrders.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBeginOrders.TabIndex = 2;
            // 
            // dateTimePickerEndOrders
            // 
            this.dateTimePickerEndOrders.Location = new System.Drawing.Point(205, 90);
            this.dateTimePickerEndOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEndOrders.Name = "dateTimePickerEndOrders";
            this.dateTimePickerEndOrders.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEndOrders.TabIndex = 3;
            // 
            // dateTimePickerBeginTop10
            // 
            this.dateTimePickerBeginTop10.Location = new System.Drawing.Point(448, 96);
            this.dateTimePickerBeginTop10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerBeginTop10.Name = "dateTimePickerBeginTop10";
            this.dateTimePickerBeginTop10.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBeginTop10.TabIndex = 4;
            this.dateTimePickerBeginTop10.ValueChanged += new System.EventHandler(this.dateTimePickerBeginTop10_ValueChanged);
            // 
            // dateTimePickerEndTopt10
            // 
            this.dateTimePickerEndTopt10.Location = new System.Drawing.Point(642, 96);
            this.dateTimePickerEndTopt10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEndTopt10.Name = "dateTimePickerEndTopt10";
            this.dateTimePickerEndTopt10.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEndTopt10.TabIndex = 5;
            this.dateTimePickerEndTopt10.ValueChanged += new System.EventHandler(this.dateTimePickerEndTopt10_ValueChanged);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(9, 63);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(38, 13);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Orders";
            // 
            // lblTop10
            // 
            this.lblTop10.AutoSize = true;
            this.lblTop10.Location = new System.Drawing.Point(446, 63);
            this.lblTop10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop10.Name = "lblTop10";
            this.lblTop10.Size = new System.Drawing.Size(38, 13);
            this.lblTop10.TabIndex = 7;
            this.lblTop10.Text = "Top10";
            this.lblTop10.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOrderRep
            // 
            this.btnOrderRep.Location = new System.Drawing.Point(115, 114);
            this.btnOrderRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderRep.Name = "btnOrderRep";
            this.btnOrderRep.Size = new System.Drawing.Size(136, 30);
            this.btnOrderRep.TabIndex = 8;
            this.btnOrderRep.Text = "Generate orders report";
            this.btnOrderRep.UseVisualStyleBackColor = true;
            this.btnOrderRep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTop10Rep
            // 
            this.btnTop10Rep.Location = new System.Drawing.Point(536, 119);
            this.btnTop10Rep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTop10Rep.Name = "btnTop10Rep";
            this.btnTop10Rep.Size = new System.Drawing.Size(152, 32);
            this.btnTop10Rep.TabIndex = 9;
            this.btnTop10Rep.Text = "Generate Top 10 Menu items";
            this.btnTop10Rep.UseVisualStyleBackColor = true;
            this.btnTop10Rep.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(26, 155);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(377, 283);
            this.listViewOrders.TabIndex = 12;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblReportsHeading
            // 
            this.lblReportsHeading.AutoSize = true;
            this.lblReportsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsHeading.Location = new System.Drawing.Point(364, 7);
            this.lblReportsHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportsHeading.Name = "lblReportsHeading";
            this.lblReportsHeading.Size = new System.Drawing.Size(98, 29);
            this.lblReportsHeading.TabIndex = 13;
            this.lblReportsHeading.Text = "Reports";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 453);
            this.Controls.Add(this.lblReportsHeading);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.btnTop10Rep);
            this.Controls.Add(this.btnOrderRep);
            this.Controls.Add(this.lblTop10);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dateTimePickerEndTopt10);
            this.Controls.Add(this.dateTimePickerBeginTop10);
            this.Controls.Add(this.dateTimePickerEndOrders);
            this.Controls.Add(this.dateTimePickerBeginOrders);
            this.Controls.Add(this.listBoxTop10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTopt10;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblTop10;
        private System.Windows.Forms.Button btnOrderRep;
        private System.Windows.Forms.Button btnTop10Rep;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Label lblReportsHeading;
    }
}