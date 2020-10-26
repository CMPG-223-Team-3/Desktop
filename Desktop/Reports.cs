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
    public partial class Reports : Form
    {
        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;

        private Desktop myMainForm;
        public Reports(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
        private void orders(DateTime beginDateTime, DateTime endDateTime)
        {

            string top10Rquery = " SELECT * FROM ORDER WHERE Order_DateTime >='"+beginDateTime+"' AND Order_DateTime<= '"+endDateTime+"'";
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(top10Rquery, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                //dataR.GetValue();
                listBoxOrders.Items.Add(dataR["Order_ID"]+","+ dataR["Order_DateTime"] + "," + dataR["Table_nr"] + "," + dataR["Waiter_ID"] + "," + dataR["Paid"] + "," + dataR["CashOrCard"] + "," + dataR["Status"] );

            }

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();

        }

        private void top10(DateTime beginDateTime, DateTime endDateTime)
        {
            //Hello sp



            // count menu items to make menu items list and amount 

            string queryCount = "SELECT COUNT(Menu_Item_ID) FROM MENU_ITEM ";
            int listSize = 0;
            
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(queryCount, connection);
            listSize = int.Parse(cmd.ExecuteScalar() + "");
            connection.Close();

            int[,] menuItemsList = new int[listSize,1];
            
            string[] Top10names = new string[10];
            int[] Top10amount = new int[10];

            // fill arrays 
            string menyQuery = "SELECT * FROM MENU_ITEM";
            connection.Open();
            //put in comand
            cmd = new MySqlCommand(menyQuery, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                int menuItemID = int.Parse(dataR["Menu_Item_ID"] + "");
                for (int i = 0; i< listSize; i++)
                {
                    menuItemsList[i,0] = menuItemID;
                    menuItemsList[i, 1] = 0;
                }

            }



            // go get orders in the selected time period 
            int quantity = 0;
            int orderID = 0;
            int menuID = 0;
            string orderRquery = "SELECT * FROM ORDERS where Order_DateTime >= '" + beginDateTime + "' AND Order_DateTime <= '" + endDateTime + "'  ";
            connection.Open();
            //put in comand
             cmd = new MySqlCommand(orderRquery, connection);
            dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {

                // go get menu items connected to ID and add 
                orderID = int.Parse(dataR["Order_ID"]+"" ) ;
                 orderRquery = "SELECT * FROM ORDERS DETAIL where Order_ID = '" + orderID + "'  ";

                connection.Open();
                //put in comand
                cmd = new MySqlCommand(orderRquery, connection);
                MySqlDataReader dataR2 = cmd.ExecuteReader();
                // data reader
                while (dataR.Read())
                {
                    menuID = int.Parse(dataR["MenuItemID"]+"");
                    quantity = int.Parse(dataR["Quantity_Orderd"] + "");

                    for (int i = 0; i < listSize; i++)
                    {
                        if (menuItemsList[i,0] == menuID)
                        {
                            menuItemsList[i,1] += quantity;
                        }

                    }

                }

                // close data reader
                dataR.Close();
                // close connection 
                connection.Close();


            }

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();

            int temp = 0;
            for (int i = 0; i < listSize; i++)
            {
                for (int k = 0; k < listSize; k++)
                {
                    if (menuItemsList[k,1]> menuItemsList[k + 1, 1])
                    {
                        temp = menuItemsList[k, 1];
                        menuItemsList[k, 1] = menuItemsList[k + 1, 1];
                        menuItemsList[k + 1, 1] = temp;
                    }
                    
                }
            }
                


        }

        private void Reports_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                 + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime beginOrders = new DateTime();
            DateTime endOrders = new DateTime();

            if (beginOrders > endOrders)
            {
                MessageBox.Show("The begin date for the report cannot be begin the end date");
            }
            else
            {
                beginOrders = dateTimePickerBeginOrders.Value;
                endOrders = dateTimePickerEndOrders.Value;
                orders(beginOrders, endOrders);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime beginTOp10 = new DateTime();
            DateTime endTop10 = new DateTime();

            if (beginTOp10 > endTop10)
            {
                MessageBox.Show("The begin date for the report cannot be begin the end date");
            }
            else
            {
                beginTOp10 = dateTimePickerBeginTop10.Value;
                endTop10 = dateTimePickerEndTopt10.Value;
                orders(beginTOp10, endTop10);
            }
            
        }

        private void dateTimePickerBeginTop10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndTopt10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTop10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myMainForm.switchTo("MainForm");
        }
    }
}
