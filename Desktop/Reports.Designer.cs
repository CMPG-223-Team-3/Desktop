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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate orders report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate Top 10 Menu items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}