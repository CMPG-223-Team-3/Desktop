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

        public MenuItems(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }

        private void addMenuItem( string menuitem, string menuItemDes, int price)
        {
            string addquery = "INSERT INTO Menu_Items (Item_Name,Item_Description,Price) VALUES('" + menuitem + "','" + menuItemDes + "','" + price + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = addquery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteMenuItem(int menuID)
        {
            string deletequery = "DELETE FROM Menu_Items WHERE Menu_Item_ID ='" + menuID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = deletequery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateMenuItem(int menuID, string menuitem, string menuItemDes, int price)
        {
            string updatequery = "UPDATE Menu_Items SET Menu_Item_ID = '" + menuID + "',Item_Name='" + menuitem + "',Item_Description='" + menuItemDes + "',Price='" + price + "' ";
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

            //GUI
            lblDeleteMenuID.ForeColor = System.Drawing.Color.White;
            lblMenuItemDes.ForeColor = System.Drawing.Color.White;
            lblMenuItemName.ForeColor = System.Drawing.Color.White;
            lblMenuItemPrice.ForeColor = System.Drawing.Color.White;
            lblMenuNameUP.ForeColor = System.Drawing.Color.White;
            lblMenuDesUP.ForeColor = System.Drawing.Color.White;
            lblMenuPriceUP.ForeColor = System.Drawing.Color.White;

            comboBoxDeleteMenuID.ForeColor = System.Drawing.Color.White;
            comboBoxMenueIDUP.ForeColor = System.Drawing.Color.White;

            tabPageAddMenuItem.ForeColor = System.Drawing.Color.White;
            tabPageDeleteMenuItem.ForeColor = System.Drawing.Color.White;
            tabPageUPmenuItem.ForeColor = System.Drawing.Color.White;

            string hexPayensGray = "#536878";

            Color color = System.Drawing.ColorTranslator.FromHtml(hexPayensGray);

            this.BackColor = color;

            tabPageAddMenuItem.BackColor = color;
            tabPageDeleteMenuItem.BackColor = color;
            tabPageUPmenuItem.BackColor = color;

            string hexNavy = "#000080";

            color = System.Drawing.ColorTranslator.FromHtml(hexNavy);

            btnAddMenuItem.ForeColor = System.Drawing.Color.White;
            btnAddMenuItem.BackColor = color;

            btnDeleteMenuItem.ForeColor = System.Drawing.Color.White;
            btnDeleteMenuItem.BackColor = color;

            btnUpMenuItem.ForeColor = System.Drawing.Color.White;
            btnUpMenuItem.BackColor = color;

        }

        private void comboBoxDeleteMenuID_Click(object sender, EventArgs e)
        {
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
            string name = textBoxMenuItemName.Text;
            string descrip = textBoxMenuItemDes.Text;
            int  price = int.Parse(textBoxMenuItemPrice.Text);

            try 
            {
                string test;
                string query = "SELECT * FROM MENU_ITEM WHERE Item_Name '"+name+ "' AND Item_Description '" + descrip + "' AND Price '" + price + "' ";
                //open connection
                connection.Open();
                //put in comand
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataR = cmd.ExecuteReader();
                // data reader
                while (dataR.Read())
                {
                    test = dataR["Item_Name"] + "";
                }
                // close data reader
                dataR.Close();
                // close connection 
                connection.Close();
                MessageBox.Show("A Menu Item with these details already exist");
            }
            catch
            {
                addMenuItem(name, descrip, price);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxDeleteMenuID.SelectedItem.ToString());

            deleteMenuItem(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxMenueIDUP.SelectedItem.ToString());
            string itemName = textBoxMenuNameUP.Text;
            string itemDes = textBoxMenuDesUP.Text;
            int price = int .Parse(textBoxMenuPriceUP.Text);
            updateMenuItem(id, itemName, itemDes, price);
        }
    }
}
