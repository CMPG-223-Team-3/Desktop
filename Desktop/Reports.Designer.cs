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
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.listBoxTop10 = new System.Windows.Forms.ListBox();
            this.dateTimePickerBeginOrders = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndOrders = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginTop10 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTopt10 = new System.Windows.Forms.DateTimePicker();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblTop10 = new System.Windows.Forms.Label();
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.btnTop10Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(185, 115);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(120, 84);
            this.listBoxOrders.TabIndex = 0;
            // 
            // listBoxTop10
            // 
            this.listBoxTop10.FormattingEnabled = true;
            this.listBoxTop10.ItemHeight = 16;
            this.listBoxTop10.Location = new System.Drawing.Point(164, 354);
            this.listBoxTop10.Name = "listBoxTop10";
            this.listBoxTop10.Size = new System.Drawing.Size(120, 84);
            this.listBoxTop10.TabIndex = 1;
            // 
            // dateTimePickerBeginOrders
            // 
            this.dateTimePickerBeginOrders.Location = new System.Drawing.Point(12, 43);
            this.dateTimePickerBeginOrders.Name = "dateTimePickerBeginOrders";
            this.dateTimePickerBeginOrders.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBeginOrders.TabIndex = 2;
            // 
            // dateTimePickerEndOrders
            // 
            this.dateTimePickerEndOrders.Location = new System.Drawing.Point(270, 43);
            this.dateTimePickerEndOrders.Name = "dateTimePickerEndOrders";
            this.dateTimePickerEndOrders.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndOrders.TabIndex = 3;
            // 
            // dateTimePickerBeginTop10
            // 
            this.dateTimePickerBeginTop10.Location = new System.Drawing.Point(12, 265);
            this.dateTimePickerBeginTop10.Name = "dateTimePickerBeginTop10";
            this.dateTimePickerBeginTop10.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBeginTop10.TabIndex = 4;
            // 
            // dateTimePickerEndTopt10
            // 
            this.dateTimePickerEndTopt10.Location = new System.Drawing.Point(270, 265);
            this.dateTimePickerEndTopt10.Name = "dateTimePickerEndTopt10";
            this.dateTimePickerEndTopt10.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndTopt10.TabIndex = 5;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(9, 9);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(52, 17);
            this.lblOrders.TabIndex = 6;
            this.lblOrders.Text = "Orders";
            // 
            // lblTop10
            // 
            this.lblTop10.AutoSize = true;
            this.lblTop10.Location = new System.Drawing.Point(9, 224);
            this.lblTop10.Name = "lblTop10";
            this.lblTop10.Size = new System.Drawing.Size(49, 17);
            this.lblTop10.TabIndex = 7;
            this.lblTop10.Text = "Top10";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(150, 72);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(181, 37);
            this.btnOrderReport.TabIndex = 8;
            this.btnOrderReport.Text = "Generate orders report";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTop10Report
            // 
            this.btnTop10Report.Location = new System.Drawing.Point(129, 294);
            this.btnTop10Report.Name = "btnTop10Report";
            this.btnTop10Report.Size = new System.Drawing.Size(202, 40);
            this.btnTop10Report.TabIndex = 9;
            this.btnTop10Report.Text = "Generate Top 10 Menu items";
            this.btnTop10Report.UseVisualStyleBackColor = true;
            this.btnTop10Report.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTop10Report);
            this.Controls.Add(this.btnOrderReport);
            this.Controls.Add(this.lblTop10);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.dateTimePickerEndTopt10);
            this.Controls.Add(this.dateTimePickerBeginTop10);
            this.Controls.Add(this.dateTimePickerEndOrders);
            this.Controls.Add(this.dateTimePickerBeginOrders);
            this.Controls.Add(this.listBoxTop10);
            this.Controls.Add(this.listBoxOrders);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.ListBox listBoxTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTopt10;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblTop10;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.Button btnTop10Report;
    }
}