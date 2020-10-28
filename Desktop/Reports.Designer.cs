﻿namespace Desktop
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
            this.btnOrderRep = new System.Windows.Forms.Button();
            this.btnTop10Rep = new System.Windows.Forms.Button();
            this.lblReportsHeading = new System.Windows.Forms.Label();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.lblEndOrder = new System.Windows.Forms.Label();
            this.lblBeginOrder = new System.Windows.Forms.Label();
            this.tabPageTop10 = new System.Windows.Forms.TabPage();
            this.lblEnd10 = new System.Windows.Forms.Label();
            this.lblBegin10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            this.tabPageTop10.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTop10
            // 
            this.listBoxTop10.FormattingEnabled = true;
            this.listBoxTop10.ItemHeight = 16;
            this.listBoxTop10.Location = new System.Drawing.Point(225, 132);
            this.listBoxTop10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTop10.Name = "listBoxTop10";
            this.listBoxTop10.Size = new System.Drawing.Size(193, 276);
            this.listBoxTop10.TabIndex = 1;
            this.listBoxTop10.SelectedIndexChanged += new System.EventHandler(this.listBoxTop10_SelectedIndexChanged);
            // 
            // dateTimePickerBeginOrders
            // 
            this.dateTimePickerBeginOrders.Location = new System.Drawing.Point(81, 44);
            this.dateTimePickerBeginOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBeginOrders.Name = "dateTimePickerBeginOrders";
            this.dateTimePickerBeginOrders.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBeginOrders.TabIndex = 2;
            // 
            // dateTimePickerEndOrders
            // 
            this.dateTimePickerEndOrders.Location = new System.Drawing.Point(355, 44);
            this.dateTimePickerEndOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndOrders.Name = "dateTimePickerEndOrders";
            this.dateTimePickerEndOrders.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndOrders.TabIndex = 3;
            // 
            // dateTimePickerBeginTop10
            // 
            this.dateTimePickerBeginTop10.Location = new System.Drawing.Point(218, 27);
            this.dateTimePickerBeginTop10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBeginTop10.Name = "dateTimePickerBeginTop10";
            this.dateTimePickerBeginTop10.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBeginTop10.TabIndex = 4;
            this.dateTimePickerBeginTop10.ValueChanged += new System.EventHandler(this.dateTimePickerBeginTop10_ValueChanged);
            // 
            // dateTimePickerEndTopt10
            // 
            this.dateTimePickerEndTopt10.Location = new System.Drawing.Point(501, 27);
            this.dateTimePickerEndTopt10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndTopt10.Name = "dateTimePickerEndTopt10";
            this.dateTimePickerEndTopt10.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndTopt10.TabIndex = 5;
            this.dateTimePickerEndTopt10.ValueChanged += new System.EventHandler(this.dateTimePickerEndTopt10_ValueChanged);
            // 
            // btnOrderRep
            // 
            this.btnOrderRep.Location = new System.Drawing.Point(624, 79);
            this.btnOrderRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderRep.Name = "btnOrderRep";
            this.btnOrderRep.Size = new System.Drawing.Size(181, 37);
            this.btnOrderRep.TabIndex = 8;
            this.btnOrderRep.Text = "Generate orders report";
            this.btnOrderRep.UseVisualStyleBackColor = true;
            this.btnOrderRep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTop10Rep
            // 
            this.btnTop10Rep.Location = new System.Drawing.Point(471, 132);
            this.btnTop10Rep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTop10Rep.Name = "btnTop10Rep";
            this.btnTop10Rep.Size = new System.Drawing.Size(203, 39);
            this.btnTop10Rep.TabIndex = 9;
            this.btnTop10Rep.Text = "Generate Top 10 Menu items";
            this.btnTop10Rep.UseVisualStyleBackColor = true;
            this.btnTop10Rep.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblReportsHeading
            // 
            this.lblReportsHeading.AutoSize = true;
            this.lblReportsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsHeading.Location = new System.Drawing.Point(485, 9);
            this.lblReportsHeading.Name = "lblReportsHeading";
            this.lblReportsHeading.Size = new System.Drawing.Size(120, 36);
            this.lblReportsHeading.TabIndex = 13;
            this.lblReportsHeading.Text = "Reports";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(23, 137);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.ScrollAlwaysVisible = true;
            this.listBoxOrders.Size = new System.Drawing.Size(1123, 292);
            this.listBoxOrders.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Controls.Add(this.tabPageTop10);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 480);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.lblEndOrder);
            this.tabPageOrder.Controls.Add(this.lblBeginOrder);
            this.tabPageOrder.Controls.Add(this.listBoxOrders);
            this.tabPageOrder.Controls.Add(this.dateTimePickerBeginOrders);
            this.tabPageOrder.Controls.Add(this.dateTimePickerEndOrders);
            this.tabPageOrder.Controls.Add(this.btnOrderRep);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1152, 451);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Order Report";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // lblEndOrder
            // 
            this.lblEndOrder.AutoSize = true;
            this.lblEndOrder.Location = new System.Drawing.Point(303, 44);
            this.lblEndOrder.Name = "lblEndOrder";
            this.lblEndOrder.Size = new System.Drawing.Size(33, 17);
            this.lblEndOrder.TabIndex = 16;
            this.lblEndOrder.Text = "End";
            // 
            // lblBeginOrder
            // 
            this.lblBeginOrder.AutoSize = true;
            this.lblBeginOrder.Location = new System.Drawing.Point(29, 44);
            this.lblBeginOrder.Name = "lblBeginOrder";
            this.lblBeginOrder.Size = new System.Drawing.Size(44, 17);
            this.lblBeginOrder.TabIndex = 15;
            this.lblBeginOrder.Text = "Begin";
            // 
            // tabPageTop10
            // 
            this.tabPageTop10.Controls.Add(this.lblEnd10);
            this.tabPageTop10.Controls.Add(this.lblBegin10);
            this.tabPageTop10.Controls.Add(this.listBoxTop10);
            this.tabPageTop10.Controls.Add(this.btnTop10Rep);
            this.tabPageTop10.Controls.Add(this.dateTimePickerBeginTop10);
            this.tabPageTop10.Controls.Add(this.dateTimePickerEndTopt10);
            this.tabPageTop10.Location = new System.Drawing.Point(4, 25);
            this.tabPageTop10.Name = "tabPageTop10";
            this.tabPageTop10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTop10.Size = new System.Drawing.Size(1152, 451);
            this.tabPageTop10.TabIndex = 1;
            this.tabPageTop10.Text = "Top 10 Report";
            this.tabPageTop10.UseVisualStyleBackColor = true;
            // 
            // lblEnd10
            // 
            this.lblEnd10.AutoSize = true;
            this.lblEnd10.Location = new System.Drawing.Point(432, 32);
            this.lblEnd10.Name = "lblEnd10";
            this.lblEnd10.Size = new System.Drawing.Size(33, 17);
            this.lblEnd10.TabIndex = 11;
            this.lblEnd10.Text = "End";
            // 
            // lblBegin10
            // 
            this.lblBegin10.AutoSize = true;
            this.lblBegin10.Location = new System.Drawing.Point(152, 32);
            this.lblBegin10.Name = "lblBegin10";
            this.lblBegin10.Size = new System.Drawing.Size(44, 17);
            this.lblBegin10.TabIndex = 10;
            this.lblBegin10.Text = "Begin";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 558);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblReportsHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageOrder.PerformLayout();
            this.tabPageTop10.ResumeLayout(false);
            this.tabPageTop10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndOrders;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTop10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTopt10;
        private System.Windows.Forms.Button btnOrderRep;
        private System.Windows.Forms.Button btnTop10Rep;
        private System.Windows.Forms.Label lblReportsHeading;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.TabPage tabPageTop10;
        private System.Windows.Forms.Label lblEndOrder;
        private System.Windows.Forms.Label lblBeginOrder;
        private System.Windows.Forms.Label lblEnd10;
        private System.Windows.Forms.Label lblBegin10;
    }
}