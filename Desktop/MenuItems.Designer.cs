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
            this.tabControlMenuItem.Location = new System.Drawing.Point(86, 92);
            this.tabControlMenuItem.Name = "tabControlMenuItem";
            this.tabControlMenuItem.SelectedIndex = 0;
            this.tabControlMenuItem.Size = new System.Drawing.Size(533, 346);
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
            this.tabPageAddMenuItem.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddMenuItem.Name = "tabPageAddMenuItem";
            this.tabPageAddMenuItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddMenuItem.Size = new System.Drawing.Size(525, 317);
            this.tabPageAddMenuItem.TabIndex = 0;
            this.tabPageAddMenuItem.Text = "Add Menu Item";
            this.tabPageAddMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(58, 217);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 7;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMenuItemPrice
            // 
            this.textBoxMenuItemPrice.Location = new System.Drawing.Point(135, 139);
            this.textBoxMenuItemPrice.Name = "textBoxMenuItemPrice";
            this.textBoxMenuItemPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuItemPrice.TabIndex = 6;
            // 
            // textBoxMenuItemDes
            // 
            this.textBoxMenuItemDes.Location = new System.Drawing.Point(135, 97);
            this.textBoxMenuItemDes.Name = "textBoxMenuItemDes";
            this.textBoxMenuItemDes.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuItemDes.TabIndex = 5;
            // 
            // textBoxMenuItemName
            // 
            this.textBoxMenuItemName.Location = new System.Drawing.Point(135, 59);
            this.textBoxMenuItemName.Name = "textBoxMenuItemName";
            this.textBoxMenuItemName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuItemName.TabIndex = 4;
            // 
            // lblMenuItemPrice
            // 
            this.lblMenuItemPrice.AutoSize = true;
            this.lblMenuItemPrice.Location = new System.Drawing.Point(61, 144);
            this.lblMenuItemPrice.Name = "lblMenuItemPrice";
            this.lblMenuItemPrice.Size = new System.Drawing.Size(40, 17);
            this.lblMenuItemPrice.TabIndex = 2;
            this.lblMenuItemPrice.Text = "Price";
            // 
            // lblMenuItemDes
            // 
            this.lblMenuItemDes.AutoSize = true;
            this.lblMenuItemDes.Location = new System.Drawing.Point(58, 102);
            this.lblMenuItemDes.Name = "lblMenuItemDes";
            this.lblMenuItemDes.Size = new System.Drawing.Size(79, 17);
            this.lblMenuItemDes.TabIndex = 1;
            this.lblMenuItemDes.Text = "Description";
            // 
            // lblMenuItemName
            // 
            this.lblMenuItemName.AutoSize = true;
            this.lblMenuItemName.Location = new System.Drawing.Point(55, 64);
            this.lblMenuItemName.Name = "lblMenuItemName";
            this.lblMenuItemName.Size = new System.Drawing.Size(45, 17);
            this.lblMenuItemName.TabIndex = 0;
            this.lblMenuItemName.Text = "Name";
            // 
            // tabPageDeleteMenuItem
            // 
            this.tabPageDeleteMenuItem.Controls.Add(this.btnDeleteMenu);
            this.tabPageDeleteMenuItem.Controls.Add(this.comboBoxDeleteMenuID);
            this.tabPageDeleteMenuItem.Controls.Add(this.lblDeleteMenuID);
            this.tabPageDeleteMenuItem.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeleteMenuItem.Name = "tabPageDeleteMenuItem";
            this.tabPageDeleteMenuItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteMenuItem.Size = new System.Drawing.Size(525, 317);
            this.tabPageDeleteMenuItem.TabIndex = 1;
            this.tabPageDeleteMenuItem.Text = "Delete Menu Item";
            this.tabPageDeleteMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(104, 223);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMenu.TabIndex = 3;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDeleteMenuID
            // 
            this.comboBoxDeleteMenuID.FormattingEnabled = true;
            this.comboBoxDeleteMenuID.Location = new System.Drawing.Point(161, 127);
            this.comboBoxDeleteMenuID.Name = "comboBoxDeleteMenuID";
            this.comboBoxDeleteMenuID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDeleteMenuID.TabIndex = 2;
            this.comboBoxDeleteMenuID.Click += new System.EventHandler(this.comboBoxDeleteMenuID_Click);
            // 
            // lblDeleteMenuID
            // 
            this.lblDeleteMenuID.AutoSize = true;
            this.lblDeleteMenuID.Location = new System.Drawing.Point(83, 127);
            this.lblDeleteMenuID.Name = "lblDeleteMenuID";
            this.lblDeleteMenuID.Size = new System.Drawing.Size(21, 17);
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
            this.tabPageUPmenuItem.Location = new System.Drawing.Point(4, 25);
            this.tabPageUPmenuItem.Name = "tabPageUPmenuItem";
            this.tabPageUPmenuItem.Size = new System.Drawing.Size(525, 317);
            this.tabPageUPmenuItem.TabIndex = 2;
            this.tabPageUPmenuItem.Text = "Update Menu Item";
            this.tabPageUPmenuItem.UseVisualStyleBackColor = true;
            // 
            // btnUpMenu
            // 
            this.btnUpMenu.Location = new System.Drawing.Point(129, 251);
            this.btnUpMenu.Name = "btnUpMenu";
            this.btnUpMenu.Size = new System.Drawing.Size(75, 23);
            this.btnUpMenu.TabIndex = 18;
            this.btnUpMenu.Text = "Update";
            this.btnUpMenu.UseVisualStyleBackColor = true;
            this.btnUpMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxMenueIDUP
            // 
            this.comboBoxMenueIDUP.FormattingEnabled = true;
            this.comboBoxMenueIDUP.Location = new System.Drawing.Point(200, 75);
            this.comboBoxMenueIDUP.Name = "comboBoxMenueIDUP";
            this.comboBoxMenueIDUP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMenueIDUP.TabIndex = 17;
            this.comboBoxMenueIDUP.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenueIDUP_SelectedIndexChanged);
            this.comboBoxMenueIDUP.Click += new System.EventHandler(this.comboBoxMenueIDUP_Click);
            // 
            // lblMenuIDUP
            // 
            this.lblMenuIDUP.AutoSize = true;
            this.lblMenuIDUP.Location = new System.Drawing.Point(123, 75);
            this.lblMenuIDUP.Name = "lblMenuIDUP";
            this.lblMenuIDUP.Size = new System.Drawing.Size(21, 17);
            this.lblMenuIDUP.TabIndex = 16;
            this.lblMenuIDUP.Text = "ID";
            // 
            // textBoxMenuPriceUP
            // 
            this.textBoxMenuPriceUP.Location = new System.Drawing.Point(200, 194);
            this.textBoxMenuPriceUP.Name = "textBoxMenuPriceUP";
            this.textBoxMenuPriceUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuPriceUP.TabIndex = 14;
            // 
            // textBoxMenuDesUP
            // 
            this.textBoxMenuDesUP.Location = new System.Drawing.Point(200, 152);
            this.textBoxMenuDesUP.Name = "textBoxMenuDesUP";
            this.textBoxMenuDesUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuDesUP.TabIndex = 13;
            // 
            // textBoxMenuNameUP
            // 
            this.textBoxMenuNameUP.Location = new System.Drawing.Point(200, 114);
            this.textBoxMenuNameUP.Name = "textBoxMenuNameUP";
            this.textBoxMenuNameUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxMenuNameUP.TabIndex = 12;
            // 
            // lblMenuPriceUP
            // 
            this.lblMenuPriceUP.AutoSize = true;
            this.lblMenuPriceUP.Location = new System.Drawing.Point(126, 199);
            this.lblMenuPriceUP.Name = "lblMenuPriceUP";
            this.lblMenuPriceUP.Size = new System.Drawing.Size(40, 17);
            this.lblMenuPriceUP.TabIndex = 10;
            this.lblMenuPriceUP.Text = "Price";
            // 
            // lblMenuDesUP
            // 
            this.lblMenuDesUP.AutoSize = true;
            this.lblMenuDesUP.Location = new System.Drawing.Point(123, 157);
            this.lblMenuDesUP.Name = "lblMenuDesUP";
            this.lblMenuDesUP.Size = new System.Drawing.Size(79, 17);
            this.lblMenuDesUP.TabIndex = 9;
            this.lblMenuDesUP.Text = "Description";
            // 
            // lblMenuNameUP
            // 
            this.lblMenuNameUP.AutoSize = true;
            this.lblMenuNameUP.Location = new System.Drawing.Point(120, 119);
            this.lblMenuNameUP.Name = "lblMenuNameUP";
            this.lblMenuNameUP.Size = new System.Drawing.Size(45, 17);
            this.lblMenuNameUP.TabIndex = 8;
            this.lblMenuNameUP.Text = "Name";
            // 
            // lblMenuItemHeading
            // 
            this.lblMenuItemHeading.AutoSize = true;
            this.lblMenuItemHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemHeading.Location = new System.Drawing.Point(307, 30);
            this.lblMenuItemHeading.Name = "lblMenuItemHeading";
            this.lblMenuItemHeading.Size = new System.Drawing.Size(170, 36);
            this.lblMenuItemHeading.TabIndex = 19;
            this.lblMenuItemHeading.Text = "Menu-Items";
            this.lblMenuItemHeading.Click += new System.EventHandler(this.lblMenuItemHeading_Click);
            // 
            // MenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenuItemHeading);
            this.Controls.Add(this.tabControlMenuItem);
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