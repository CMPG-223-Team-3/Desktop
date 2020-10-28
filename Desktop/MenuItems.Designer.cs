namespace Desktop
{
    partial class MenuItems
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
            this.tabControlMenuItem = new System.Windows.Forms.TabControl();
            this.tabPageAddMenuItem = new System.Windows.Forms.TabPage();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.textBoxMenuItemPrice = new System.Windows.Forms.TextBox();
            this.textBoxMenuItemDes = new System.Windows.Forms.TextBox();
            this.textBoxMenuItemName = new System.Windows.Forms.TextBox();
            this.lblMenuItemPrice = new System.Windows.Forms.Label();
            this.lblMenuItemDes = new System.Windows.Forms.Label();
            this.lblMenuItemName = new System.Windows.Forms.Label();
            this.tabPageDeleteMenuItem = new System.Windows.Forms.TabPage();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.comboBoxDeleteMenuID = new System.Windows.Forms.ComboBox();
            this.lblDeleteMenuID = new System.Windows.Forms.Label();
            this.tabPageUPmenuItem = new System.Windows.Forms.TabPage();
            this.btnUpMenu = new System.Windows.Forms.Button();
            this.comboBoxMenueIDUP = new System.Windows.Forms.ComboBox();
            this.lblMenuIDUP = new System.Windows.Forms.Label();
            this.textBoxMenuPriceUP = new System.Windows.Forms.TextBox();
            this.textBoxMenuDesUP = new System.Windows.Forms.TextBox();
            this.textBoxMenuNameUP = new System.Windows.Forms.TextBox();
            this.lblMenuPriceUP = new System.Windows.Forms.Label();
            this.lblMenuDesUP = new System.Windows.Forms.Label();
            this.lblMenuNameUP = new System.Windows.Forms.Label();
            this.lblMenuItemHeading = new System.Windows.Forms.Label();
            this.tabControlMenuItem.SuspendLayout();
            this.tabPageAddMenuItem.SuspendLayout();
            this.tabPageDeleteMenuItem.SuspendLayout();
            this.tabPageUPmenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenuItem
            // 
            this.tabControlMenuItem.Controls.Add(this.tabPageAddMenuItem);
            this.tabControlMenuItem.Controls.Add(this.tabPageDeleteMenuItem);
            this.tabControlMenuItem.Controls.Add(this.tabPageUPmenuItem);
            this.tabControlMenuItem.Location = new System.Drawing.Point(11, 55);
            this.tabControlMenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMenuItem.Name = "tabControlMenuItem";
            this.tabControlMenuItem.SelectedIndex = 0;
            this.tabControlMenuItem.Size = new System.Drawing.Size(578, 300);
            this.tabControlMenuItem.TabIndex = 1;
            // 
            // tabPageAddMenuItem
            // 
            this.tabPageAddMenuItem.Controls.Add(this.btnAddMenu);
            this.tabPageAddMenuItem.Controls.Add(this.textBoxMenuItemPrice);
            this.tabPageAddMenuItem.Controls.Add(this.textBoxMenuItemDes);
            this.tabPageAddMenuItem.Controls.Add(this.textBoxMenuItemName);
            this.tabPageAddMenuItem.Controls.Add(this.lblMenuItemPrice);
            this.tabPageAddMenuItem.Controls.Add(this.lblMenuItemDes);
            this.tabPageAddMenuItem.Controls.Add(this.lblMenuItemName);
            this.tabPageAddMenuItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddMenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAddMenuItem.Name = "tabPageAddMenuItem";
            this.tabPageAddMenuItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAddMenuItem.Size = new System.Drawing.Size(570, 274);
            this.tabPageAddMenuItem.TabIndex = 0;
            this.tabPageAddMenuItem.Text = "Add Menu Item";
            this.tabPageAddMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(44, 176);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(56, 19);
            this.btnAddMenu.TabIndex = 7;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMenuItemPrice
            // 
            this.textBoxMenuItemPrice.Location = new System.Drawing.Point(101, 113);
            this.textBoxMenuItemPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuItemPrice.Name = "textBoxMenuItemPrice";
            this.textBoxMenuItemPrice.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuItemPrice.TabIndex = 6;
            // 
            // textBoxMenuItemDes
            // 
            this.textBoxMenuItemDes.Location = new System.Drawing.Point(101, 79);
            this.textBoxMenuItemDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuItemDes.Name = "textBoxMenuItemDes";
            this.textBoxMenuItemDes.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuItemDes.TabIndex = 5;
            // 
            // textBoxMenuItemName
            // 
            this.textBoxMenuItemName.Location = new System.Drawing.Point(101, 48);
            this.textBoxMenuItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuItemName.Name = "textBoxMenuItemName";
            this.textBoxMenuItemName.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuItemName.TabIndex = 4;
            // 
            // lblMenuItemPrice
            // 
            this.lblMenuItemPrice.AutoSize = true;
            this.lblMenuItemPrice.Location = new System.Drawing.Point(46, 117);
            this.lblMenuItemPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuItemPrice.Name = "lblMenuItemPrice";
            this.lblMenuItemPrice.Size = new System.Drawing.Size(31, 13);
            this.lblMenuItemPrice.TabIndex = 2;
            this.lblMenuItemPrice.Text = "Price";
            // 
            // lblMenuItemDes
            // 
            this.lblMenuItemDes.AutoSize = true;
            this.lblMenuItemDes.Location = new System.Drawing.Point(44, 83);
            this.lblMenuItemDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuItemDes.Name = "lblMenuItemDes";
            this.lblMenuItemDes.Size = new System.Drawing.Size(60, 13);
            this.lblMenuItemDes.TabIndex = 1;
            this.lblMenuItemDes.Text = "Description";
            // 
            // lblMenuItemName
            // 
            this.lblMenuItemName.AutoSize = true;
            this.lblMenuItemName.Location = new System.Drawing.Point(41, 52);
            this.lblMenuItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuItemName.Name = "lblMenuItemName";
            this.lblMenuItemName.Size = new System.Drawing.Size(35, 13);
            this.lblMenuItemName.TabIndex = 0;
            this.lblMenuItemName.Text = "Name";
            // 
            // tabPageDeleteMenuItem
            // 
            this.tabPageDeleteMenuItem.Controls.Add(this.btnDeleteMenu);
            this.tabPageDeleteMenuItem.Controls.Add(this.comboBoxDeleteMenuID);
            this.tabPageDeleteMenuItem.Controls.Add(this.lblDeleteMenuID);
            this.tabPageDeleteMenuItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteMenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDeleteMenuItem.Name = "tabPageDeleteMenuItem";
            this.tabPageDeleteMenuItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDeleteMenuItem.Size = new System.Drawing.Size(392, 255);
            this.tabPageDeleteMenuItem.TabIndex = 1;
            this.tabPageDeleteMenuItem.Text = "Delete Menu Item";
            this.tabPageDeleteMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(78, 181);
            this.btnDeleteMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteMenu.TabIndex = 3;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDeleteMenuID
            // 
            this.comboBoxDeleteMenuID.FormattingEnabled = true;
            this.comboBoxDeleteMenuID.Location = new System.Drawing.Point(121, 103);
            this.comboBoxDeleteMenuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDeleteMenuID.Name = "comboBoxDeleteMenuID";
            this.comboBoxDeleteMenuID.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDeleteMenuID.TabIndex = 2;
            this.comboBoxDeleteMenuID.Click += new System.EventHandler(this.comboBoxDeleteMenuID_Click);
            // 
            // lblDeleteMenuID
            // 
            this.lblDeleteMenuID.AutoSize = true;
            this.lblDeleteMenuID.Location = new System.Drawing.Point(62, 103);
            this.lblDeleteMenuID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteMenuID.Name = "lblDeleteMenuID";
            this.lblDeleteMenuID.Size = new System.Drawing.Size(18, 13);
            this.lblDeleteMenuID.TabIndex = 1;
            this.lblDeleteMenuID.Text = "ID";
            // 
            // tabPageUPmenuItem
            // 
            this.tabPageUPmenuItem.Controls.Add(this.btnUpMenu);
            this.tabPageUPmenuItem.Controls.Add(this.comboBoxMenueIDUP);
            this.tabPageUPmenuItem.Controls.Add(this.lblMenuIDUP);
            this.tabPageUPmenuItem.Controls.Add(this.textBoxMenuPriceUP);
            this.tabPageUPmenuItem.Controls.Add(this.textBoxMenuDesUP);
            this.tabPageUPmenuItem.Controls.Add(this.textBoxMenuNameUP);
            this.tabPageUPmenuItem.Controls.Add(this.lblMenuPriceUP);
            this.tabPageUPmenuItem.Controls.Add(this.lblMenuDesUP);
            this.tabPageUPmenuItem.Controls.Add(this.lblMenuNameUP);
            this.tabPageUPmenuItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageUPmenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUPmenuItem.Name = "tabPageUPmenuItem";
            this.tabPageUPmenuItem.Size = new System.Drawing.Size(392, 255);
            this.tabPageUPmenuItem.TabIndex = 2;
            this.tabPageUPmenuItem.Text = "Update Menu Item";
            this.tabPageUPmenuItem.UseVisualStyleBackColor = true;
            // 
            // btnUpMenu
            // 
            this.btnUpMenu.Location = new System.Drawing.Point(97, 204);
            this.btnUpMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpMenu.Name = "btnUpMenu";
            this.btnUpMenu.Size = new System.Drawing.Size(56, 19);
            this.btnUpMenu.TabIndex = 18;
            this.btnUpMenu.Text = "Update";
            this.btnUpMenu.UseVisualStyleBackColor = true;
            this.btnUpMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxMenueIDUP
            // 
            this.comboBoxMenueIDUP.FormattingEnabled = true;
            this.comboBoxMenueIDUP.Location = new System.Drawing.Point(150, 61);
            this.comboBoxMenueIDUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMenueIDUP.Name = "comboBoxMenueIDUP";
            this.comboBoxMenueIDUP.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMenueIDUP.TabIndex = 17;
            this.comboBoxMenueIDUP.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenueIDUP_SelectedIndexChanged);
            this.comboBoxMenueIDUP.Click += new System.EventHandler(this.comboBoxMenueIDUP_Click);
            // 
            // lblMenuIDUP
            // 
            this.lblMenuIDUP.AutoSize = true;
            this.lblMenuIDUP.Location = new System.Drawing.Point(92, 61);
            this.lblMenuIDUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuIDUP.Name = "lblMenuIDUP";
            this.lblMenuIDUP.Size = new System.Drawing.Size(18, 13);
            this.lblMenuIDUP.TabIndex = 16;
            this.lblMenuIDUP.Text = "ID";
            // 
            // textBoxMenuPriceUP
            // 
            this.textBoxMenuPriceUP.Location = new System.Drawing.Point(150, 158);
            this.textBoxMenuPriceUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuPriceUP.Name = "textBoxMenuPriceUP";
            this.textBoxMenuPriceUP.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuPriceUP.TabIndex = 14;
            // 
            // textBoxMenuDesUP
            // 
            this.textBoxMenuDesUP.Location = new System.Drawing.Point(150, 124);
            this.textBoxMenuDesUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuDesUP.Name = "textBoxMenuDesUP";
            this.textBoxMenuDesUP.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuDesUP.TabIndex = 13;
            // 
            // textBoxMenuNameUP
            // 
            this.textBoxMenuNameUP.Location = new System.Drawing.Point(150, 93);
            this.textBoxMenuNameUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMenuNameUP.Name = "textBoxMenuNameUP";
            this.textBoxMenuNameUP.Size = new System.Drawing.Size(76, 20);
            this.textBoxMenuNameUP.TabIndex = 12;
            // 
            // lblMenuPriceUP
            // 
            this.lblMenuPriceUP.AutoSize = true;
            this.lblMenuPriceUP.Location = new System.Drawing.Point(94, 162);
            this.lblMenuPriceUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuPriceUP.Name = "lblMenuPriceUP";
            this.lblMenuPriceUP.Size = new System.Drawing.Size(31, 13);
            this.lblMenuPriceUP.TabIndex = 10;
            this.lblMenuPriceUP.Text = "Price";
            // 
            // lblMenuDesUP
            // 
            this.lblMenuDesUP.AutoSize = true;
            this.lblMenuDesUP.Location = new System.Drawing.Point(92, 128);
            this.lblMenuDesUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuDesUP.Name = "lblMenuDesUP";
            this.lblMenuDesUP.Size = new System.Drawing.Size(60, 13);
            this.lblMenuDesUP.TabIndex = 9;
            this.lblMenuDesUP.Text = "Description";
            // 
            // lblMenuNameUP
            // 
            this.lblMenuNameUP.AutoSize = true;
            this.lblMenuNameUP.Location = new System.Drawing.Point(90, 97);
            this.lblMenuNameUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuNameUP.Name = "lblMenuNameUP";
            this.lblMenuNameUP.Size = new System.Drawing.Size(35, 13);
            this.lblMenuNameUP.TabIndex = 8;
            this.lblMenuNameUP.Text = "Name";
            // 
            // lblMenuItemHeading
            // 
            this.lblMenuItemHeading.AutoSize = true;
            this.lblMenuItemHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemHeading.Location = new System.Drawing.Point(230, 24);
            this.lblMenuItemHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuItemHeading.Name = "lblMenuItemHeading";
            this.lblMenuItemHeading.Size = new System.Drawing.Size(139, 29);
            this.lblMenuItemHeading.TabIndex = 19;
            this.lblMenuItemHeading.Text = "Menu-Items";
            this.lblMenuItemHeading.Click += new System.EventHandler(this.lblMenuItemHeading_Click);
            // 
            // MenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblMenuItemHeading);
            this.Controls.Add(this.tabControlMenuItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuItems";
            this.Text = "MenuItems";
            this.Load += new System.EventHandler(this.MenuItems_Load);
            this.tabControlMenuItem.ResumeLayout(false);
            this.tabPageAddMenuItem.ResumeLayout(false);
            this.tabPageAddMenuItem.PerformLayout();
            this.tabPageDeleteMenuItem.ResumeLayout(false);
            this.tabPageDeleteMenuItem.PerformLayout();
            this.tabPageUPmenuItem.ResumeLayout(false);
            this.tabPageUPmenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenuItem;
        private System.Windows.Forms.TabPage tabPageAddMenuItem;
        private System.Windows.Forms.TextBox textBoxMenuItemPrice;
        private System.Windows.Forms.TextBox textBoxMenuItemDes;
        private System.Windows.Forms.TextBox textBoxMenuItemName;
        private System.Windows.Forms.Label lblMenuItemPrice;
        private System.Windows.Forms.Label lblMenuItemDes;
        private System.Windows.Forms.Label lblMenuItemName;
        private System.Windows.Forms.TabPage tabPageDeleteMenuItem;
        private System.Windows.Forms.ComboBox comboBoxDeleteMenuID;
        private System.Windows.Forms.Label lblDeleteMenuID;
        private System.Windows.Forms.TabPage tabPageUPmenuItem;
        private System.Windows.Forms.ComboBox comboBoxMenueIDUP;
        private System.Windows.Forms.Label lblMenuIDUP;
        private System.Windows.Forms.TextBox textBoxMenuPriceUP;
        private System.Windows.Forms.TextBox textBoxMenuDesUP;
        private System.Windows.Forms.TextBox textBoxMenuNameUP;
        private System.Windows.Forms.Label lblMenuPriceUP;
        private System.Windows.Forms.Label lblMenuDesUP;
        private System.Windows.Forms.Label lblMenuNameUP;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnUpMenu;
        private System.Windows.Forms.Label lblMenuItemHeading;
    }
}