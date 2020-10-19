using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }

        private void addMenuItem(int menuID, string menuitem, string menuItemDes ,int price)
        {
            string addquery = "INSERT INTO Menu_Items (Menu_Item_ID,Item_Name,Item_Description,Price) VALUES('" +menuID +"','" +menuitem+"','" +menuItemDes +"','" +price +"')";
        }

        private void deleteMenuItem(int menuID)
        {
            string deletequery = "DELETE FROM Menu_Items WHERE Menu_Item_ID ='"+menuID+"'";
        }

        private void updateMenuItem(int menuID, string menuitem, string menuItemDes, int price)
        {
            string updatequery = "UPDATE Menu_Items SET Menu_Item_ID = '" + menuID + "',Item_Name='" + menuitem + "',Item_Description='" + menuItemDes + "',Price='" + price + "' ";
        }

        private void MenuItems_Load(object sender, EventArgs e)
        {

        }
    }
}
