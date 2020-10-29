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
        private string server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
        private string database = "CMPG_223_DB";
        private string uid = "admin";
        private string password = "cmpg22310";
        string connectionstring;
        private Desktop myMainForm;
        private MySqlDataAdapter adap;
        private MySqlCommandBuilder build;
        private DataTable menu = new DataTable();

        public MenuItems(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }

        private void addMenuItem(string menuitem, string menuItemDes, double price)
        {
            string addquery = "INSERT INTO `MENU-ITEM` (Item_Name,Item_Description,Price) VALUES('" + menuitem + "','" + menuItemDes + "','" + price + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = addquery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteMenuItem(int menuID)
        {
            string deletequery = "DELETE FROM `MENU-ITEM` WHERE Menu_Item_ID ='" + menuID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = deletequery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

           
        }

        private void updateMenuItem(int menuID, string menuitem, string menuItemDes, double price)
        {
            string updatequery = "UPDATE `MENU-ITEM` SET Menu_Item_ID = '" + menuID + "',Item_Name='" + menuitem + "',Item_Description='" + menuItemDes + "',Price='" + price + "' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = updatequery;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void MenuItems_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid
                 + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            lblMenuItemHeading.ForeColor = System.Drawing.Color.White;
            lblDeleteMenuID.ForeColor = System.Drawing.Color.White;
            lblMenuItemName.ForeColor = System.Drawing.Color.White;
            lblMenuItemPrice.ForeColor = System.Drawing.Color.White;
            lblMenuItemDes.ForeColor = System.Drawing.Color.White;
            lblMenuIDUP.ForeColor = System.Drawing.Color.White;
            lblMenuNameUP.ForeColor = System.Drawing.Color.White;
            lblMenuPriceUP.ForeColor = System.Drawing.Color.White;
            lblMenuDesUP.ForeColor = System.Drawing.Color.White;

            comboBoxDeleteMenuID.ForeColor = System.Drawing.Color.White;
            comboBoxMenueIDUP.ForeColor = System.Drawing.Color.White;

            textBoxMenuItemName.ForeColor = System.Drawing.Color.White;
            textBoxMenuItemDes.ForeColor = System.Drawing.Color.White;
            textBoxMenuItemPrice.ForeColor = System.Drawing.Color.White;
            textBoxMenuNameUP.ForeColor = System.Drawing.Color.White;
            textBoxMenuItemDes.ForeColor = System.Drawing.Color.White;
            textBoxMenuPriceUP.ForeColor = System.Drawing.Color.White;
            textBoxMenuDesUP.ForeColor = System.Drawing.Color.White;



            string hex = "#536878";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            this.BackColor = color;

            comboBoxDeleteMenuID.BackColor = color;
            comboBoxMenueIDUP.BackColor = color;

            textBoxMenuItemName.BackColor = color;
            textBoxMenuItemDes.BackColor = color;
            textBoxMenuItemPrice.BackColor = color;
            textBoxMenuNameUP.BackColor = color;
            textBoxMenuItemDes.BackColor = color;
            textBoxMenuPriceUP.BackColor = color;
            textBoxMenuDesUP.BackColor = color;

            hex = "#19262d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            
            tabPageAddMenuItem.ForeColor = System.Drawing.Color.White;
            tabPageDeleteMenuItem.ForeColor = System.Drawing.Color.White;
            tabPageUPmenuItem.ForeColor = System.Drawing.Color.White;
            tabPageUPmenuItem.BackColor = color;
            tabPageDeleteMenuItem.BackColor = color;
            tabPageAddMenuItem.BackColor = color;

            

            




            hex = "#020b0d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            btnAddMenu.BackColor = color;
            btnAddMenu.ForeColor = System.Drawing.Color.White;

            btnDeleteMenu.BackColor = color;
            btnDeleteMenu.ForeColor = System.Drawing.Color.White;

            btnUpMenu.BackColor = color;
            btnUpMenu.ForeColor = System.Drawing.Color.White;
        }

        private void comboBoxDeleteMenuID_Click(object sender, EventArgs e)
        {
            comboBoxDeleteMenuID.Items.Clear();
            // When combo box clicked all Menu IDs are put in the items


            string query = "SELECT * FROM `MENU-ITEM`";
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
            comboBoxMenueIDUP.Items.Clear();
            // When combo box clicked all Menu IDs are put in the items

            string query = "SELECT * FROM `MENU-ITEM`";
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
            bool empty = true;

            if (textBoxMenuItemPrice.Text==""|| textBoxMenuItemPrice.Text == "" || textBoxMenuItemPrice.Text == "" )
            {
                MessageBox.Show(" There are empty values , connot input empty values");
            }
            else
            {
                empty = false;
            }
                //Add menu item 
             try
            {
                string name = textBoxMenuItemName.Text;
                string descrip = textBoxMenuItemDes.Text;


                if (double.TryParse(textBoxMenuItemPrice.Text, out double price))
                {
                    if(!empty)
                    {
                        addMenuItem(name, descrip, price);
                        MessageBox.Show("Menu Item has been  added");
                    }
                    
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
            int payed =0;
            int delivered=0 ;
            int orderID = 0;
            string query = "";
            bool can = false;
            bool contain = true;
            int id = 0;




                try
                {
                 id = int.Parse(comboBoxDeleteMenuID.SelectedItem.ToString());
                 query = "SELECT * FROM `ORDER-DETAIL` WHERE Menu_Item_ID ='" + id + "'"; 
                
                  MySqlCommand cmmd = new MySqlCommand();
                  cmmd.CommandText = query;
                  cmmd.Connection = connection;
                  try
                  {
                    adap = new MySqlDataAdapter(cmmd);
                    build = new MySqlCommandBuilder(adap);

                    DataTable ds = new DataTable();
                    adap.Fill(ds);

                    menu = ds;
                  }
                  catch
                  {

                  }

                
                // delete menu item

                foreach( DataRow r in menu.Rows)
                {
                    orderID = int.Parse(r["Order_ID"].ToString() );
                    // check of order doesnt exist with this menuID
                    query = "SELECT * FROM `ORDER` WHERE Order_ID ='" + orderID + "'";
                    //open connection
                    connection.Open();
                    //put in comand
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataR = cmd.ExecuteReader();
                    // data reader
                    while (dataR.Read())
                    {
                        payed = int.Parse(dataR["Paid"] + "");
                        delivered = int.Parse(dataR["Status"] + "");




                    }

                    dataR.Close();
                    // close connection
                    connection.Close();
                }
                
                       
                        
                             

                
                }
                catch
                {
                   contain = false;
                   
                }
            


            if ((payed == 1 && delivered == 1)||!contain)
            {
                can = true;
            }
            else
            { MessageBox.Show("Connot delete Menu item , there ore orders with this item that are not payed and delivered"); 
            
            }

            try
            {
                if (can)

                {
                    deleteMenuItem(id);
                    MessageBox.Show("Menu Item has been deleted");
                }
            }
            catch
            {
                MessageBox.Show("Menu Item could not be  deleted");
            }
            
            

               
            
            
            
                
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // update menuItems

            bool empty = true;
            if (textBoxMenuNameUP.Text == "" || textBoxMenuPriceUP.Text == "" || textBoxMenuDesUP.Text == "")
            {
                MessageBox.Show(" There are empty values , connot input empty values");
            }
            else
            {
                empty = false;
            }
            try
            {
                int id = int.Parse(comboBoxMenueIDUP.SelectedItem.ToString());
                string itemName = textBoxMenuNameUP.Text;
                string itemDes = textBoxMenuDesUP.Text;

                

                if (double.TryParse(textBoxMenuPriceUP.Text,out double price ))
                {
                    if( !empty)
                    {
                        updateMenuItem(id, itemName, itemDes, price);
                        MessageBox.Show("Menu Item has  been added");
                    }
                    
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
            string query = "SELECT * FROM `MENU-ITEM` WHERE Menu_Item_ID = '"+int.Parse(comboBoxMenueIDUP.SelectedItem.ToString())+"'";
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

        private void lblMenuItemHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
