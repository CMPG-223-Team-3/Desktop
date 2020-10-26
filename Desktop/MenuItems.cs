using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desktop

{
    public partial class MenuItems : Form
    {
        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;
        private Desktop myMainForm;

        public MenuItems(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }

        private void addMenuItem( string menuitem, string menuItemDes, int price)
        {
            string addquery = "INSERT INTO MENU_ITEM (Item_Name,Item_Description,Price) VALUES('" + menuitem + "','" + menuItemDes + "','" + price + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = addquery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteMenuItem(int menuID)
        {
            string deletequery = "DELETE FROM MENU_ITEM WHERE Menu_Item_ID ='" + menuID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = deletequery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

            string delete2query = "DELETE FROM ORDER DETAIL WHERE Menu_Item_ID ='" + menuID + "'";
            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = delete2query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateMenuItem(int menuID, string menuitem, string menuItemDes, int price)
        {
            string updatequery = "UPDATE MENU_ITEM SET Menu_Item_ID = '" + menuID + "',Item_Name='" + menuitem + "',Item_Description='" + menuItemDes + "',Price='" + price + "' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = updatequery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void MenuItems_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                 + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }

        private void comboBoxDeleteMenuID_Click(object sender, EventArgs e)
        {

            // When combo box clicked all Menu IDs are put in the items


            string query = "SELECT * FROM MENU_ITEM";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteMenuID.Items.Add(dataR["Menu_Item_ID"]);
            }
            // close data reader
            dataR.Close();
            // close connection
            connection.Close();
        }

        private void comboBoxMenueIDUP_Click(object sender, EventArgs e)
        {
            // When combo box clicked all Menu IDs are put in the items

            string query = "SELECT * FROM MENU_ITEM";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxMenueIDUP.Items.Add(dataR["Menu_Item_ID"]);
            }
            // close data reader
            dataR.Close();
            // close connection
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Add menu item 
            try
            {
                string name = textBoxMenuItemName.Text;
                string descrip = textBoxMenuItemDes.Text;
                

                if (int.TryParse(textBoxMenuItemPrice.Text, out int price))
                {
                    addMenuItem(name, descrip, price);
                    MessageBox.Show("Menu Item has been  added");
                }
                else
                {
                   MessageBox.Show("Price has to be a number");
                    textBoxMenuItemPrice.Focus();
                }

              
                
            }
            catch 
            {
                MessageBox.Show("Menu Item could not be added");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete menu item
            try 
            {
                int id = int.Parse(comboBoxDeleteMenuID.SelectedItem.ToString());

                deleteMenuItem(id);
                MessageBox.Show("Menu Item has been deleted");
            }
            catch
            {
                MessageBox.Show("Error.Menu Item could not be deleted");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // update menuItems
            try
            {
                int id = int.Parse(comboBoxMenueIDUP.SelectedItem.ToString());
                string itemName = textBoxMenuNameUP.Text;
                string itemDes = textBoxMenuDesUP.Text;

                

                if (int.TryParse(textBoxMenuPriceUP.Text,out int price ))
                {
                    updateMenuItem(id, itemName, itemDes, price);
                    MessageBox.Show("Menu Item has  been added");
                }
                else
                {
                    MessageBox.Show("Price should be a number");
                    textBoxMenuPriceUP.Focus();
                }
               
            }
            catch
            {
                MessageBox.Show("Menu Item could not be added");
            }
            
        }

        private void comboBoxMenueIDUP_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Menu info linked to Id  is put into update texboxes and comboboxes so it can be edited
            string query = "SELECT * FROM MENU_ITEM WHERE Menu_Item_ID = '"+int.Parse(comboBoxMenueIDUP.SelectedItem.ToString())+"'";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                textBoxMenuDesUP.Text = dataR["Item_Description"] + "";
                textBoxMenuNameUP.Text = dataR["Item_Name"]+"";
                textBoxMenuPriceUP.Text = dataR["Price"] + "";

            }
            // close data reader
            dataR.Close();
            // close connection
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myMainForm.switchTo("MainForm");
        }
    }
}
