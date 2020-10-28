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
        private string server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
        private string database = "CMPG_223_DB";
        private string uid = "admin";
        private string password = "cmpg22310";
        string connectionstring;
        private MySqlDataAdapter adap;
        private MySqlCommandBuilder build;
        private DataTable order = new DataTable();
        private DataTable order10 = new DataTable();

        private Desktop myMainForm;
        public Reports(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
        private void orders(DateTime beginDateTime, DateTime endDateTime)
        {



            listViewOrders.Columns.Add("ORDER ID", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Date and Time", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Table number", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Waiter ID", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Paid", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Cash or Card", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Status", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Menu Item ID", 3, HorizontalAlignment.Left);
            listViewOrders.Columns.Add("Quantity orderd", 3, HorizontalAlignment.Left);
            

            int cashORcard = 0;
            int status = 0;
            int paid = 0;
            int waiter = 0;
            int table = 0;
            DateTime date =new  DateTime();
            int orderID = 0;
            string orderQuery = " SELECT * FROM `ORDER` WHERE `Order_Date_Time` >='"+ beginDateTime.ToString("yyyy-MM-dd H:mm:ss") +"' AND `Order_Date_Time` <= '"+endDateTime.ToString("yyyy-MM-dd H:mm:ss") + "'";

            MySqlCommand cmmd = new MySqlCommand();
            cmmd.CommandText = orderQuery;
            cmmd.Connection = connection;
            try
            {
                adap = new MySqlDataAdapter(cmmd);
                build = new MySqlCommandBuilder(adap);

                DataTable ds = new DataTable();
                adap.Fill(ds);

                order = ds;
            }
            catch
            {

            }

            MySqlCommand cmd = new MySqlCommand(orderQuery, connection);
         
            // data reader
            var itemOrder = new ListViewItem(new[] { "", "", "", "", "", "", "", "", "" });
            foreach ( DataRow r in order.Rows)
            {
                orderID = int.Parse(r["Order_ID"].ToString());
                date = DateTime.Parse(r["Order_Date_Time"].ToString());
                table = int.Parse(r["Table_nr"].ToString());
                waiter = int.Parse(r["Waiter_ID"].ToString());
                status = int.Parse(r["Status"].ToString());
                cashORcard = int.Parse(r["CashOrCard"].ToString());
                paid = int.Parse(r["Paid"].ToString());

                // get Order detail info on order id 
                orderQuery = " SELECT * FROM ORDER-DETAIL WHERE Order_ID ='" + orderID + "'";
                connection.Open();
                //put in comand
                cmd = new MySqlCommand(orderQuery, connection);
                MySqlDataReader dataR1 = cmd.ExecuteReader();
                // data reader
                while (dataR1.Read())
                {
                    //dataR.GetValue();
                    //listViewOrders.Items.Add(orderID.ToString(), date.ToString, table.ToString,waiter.ToString,cashORcard.ToString,paid.ToString(),status.ToString, dataR["MenuItemID"] +"",dataR["Quantity_Orderd"] +"");
                    itemOrder = new ListViewItem(new[] { orderID.ToString(), date.ToString(), table.ToString(), waiter.ToString(), cashORcard.ToString(), paid.ToString(), status.ToString(), dataR1["MenuItemID"] + "", dataR1["Quantity_Orderd"] + "" });
                    listViewOrders.Items.Add(itemOrder);

                }

                 //close data reader
                dataR1.Close();
                //close connection 
                connection.Close();
            }




            /*connection.Open();

            //put in comand
            
            while (dataR.Read())
            {
                //dataR.GetValue();

                
                //listViewOrders.Items.Add(dataR["Order_ID"]+","+ dataR["Order_DateTime"] + "," + dataR["Table_nr"] + "," + dataR["Waiter_ID"] + "," + dataR["Paid"] + "," + dataR["CashOrCard"] + "," + dataR["Status"] );
                

            }

            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();*/

        }

        private void top10(DateTime beginDateTime, DateTime endDateTime)
        {
            //Hello sp



            // count menu items to make menu items list and amount 

            string queryCount = "SELECT COUNT(Menu_Item_ID) FROM MENU-ITEM ";
            int listSize = 0;
            
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(queryCount, connection);
            listSize = int.Parse(cmd.ExecuteScalar() + "");
            connection.Close();

            int[,] menuItemsList = new int[listSize,1];
            
            string[] Top10names = new string[10];
            int[] Top10amount = new int[10];

            // fill arrays 
            string menuQuery = "SELECT * FROM MENU-ITEM";
            connection.Open();
            //put in comand
            cmd = new MySqlCommand(menuQuery, connection);
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

            dataR.Close();
            connection.Close();


            // go get orders in the selected time period 
            int quantity = 0;
            int orderID = 0;
            int menuID = 0;

            menuQuery = "SELECT * FROM ORDERS where Order_DateTime >= '" + beginDateTime + "' AND Order_DateTime <= '" + endDateTime + "'  ";
            MySqlCommand cmmd = new MySqlCommand();
            cmmd.CommandText = menuQuery;
            cmmd.Connection = connection;
            try
            {
                adap = new MySqlDataAdapter(cmmd);
                build = new MySqlCommandBuilder(adap);

                DataTable ds = new DataTable();
                adap.Fill(ds);

                order10 = ds;
            }
            catch 
            {
                
            }

            foreach (DataRow r in order10.Rows)
            {

                // go get menu items connected to ID and add 
               
                orderID = int.Parse(r["Order_ID"].ToString());
                menuQuery = "SELECT * FROM ORDERS-DETAIL WHERE Order_ID = '" + orderID + "'  ";

                connection.Open();
                //put in comand
                cmd = new MySqlCommand(menuQuery, connection);
                MySqlDataReader dataR2 = cmd.ExecuteReader();
                // data reader
                while (dataR.Read())
                {
                    menuID = int.Parse(dataR["MenuItemID"] + "");
                    quantity = int.Parse(dataR["Quantity_Orderd"] + "");

                    for (int i = 0; i < listSize; i++)
                    {
                        if (menuItemsList[i, 0] == menuID)
                        {
                            menuItemsList[i, 1] += quantity;
                        }

                    }

                }

                // close data reader
                dataR.Close();
                // close connection 
                connection.Close();

            }








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
            
            for (int k=listSize; k>= listSize-10;k--)
            {
                menuQuery = "SELECT * FROM MENU-ITEM where Menu_Item_ID = '"+menuItemsList[k,0]+"'  ";

                connection.Open();
                //put in comand
                cmd = new MySqlCommand(menuQuery, connection);
                MySqlDataReader dataR2 = cmd.ExecuteReader();
                // data reader
                while (dataR2.Read())
                {


                    listBoxTop10.Items.Add(k.ToString() + ". " + dataR2["Item_Name"] + "");

                }

                // close data reader
                dataR2.Close();
                // close connection 
                connection.Close();
            }

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid
                 + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            lblOrder.ForeColor = System.Drawing.Color.White;
            lblTop10.ForeColor = System.Drawing.Color.White;
            btnOrderRep.ForeColor = System.Drawing.Color.White;
            btnTop10Rep.ForeColor = System.Drawing.Color.White;
            dateTimePickerBeginOrders.ForeColor = System.Drawing.Color.White;
            dateTimePickerBeginTop10.ForeColor = System.Drawing.Color.White;
            dateTimePickerEndOrders.ForeColor = System.Drawing.Color.White;
            dateTimePickerEndTopt10.ForeColor = System.Drawing.Color.White;
            lblReportsHeading.ForeColor = System.Drawing.Color.White;






            string hex = "#536878";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            this.BackColor = color;

            dateTimePickerBeginOrders.BackColor = color;
            dateTimePickerBeginTop10.BackColor = color;



            hex = "#19262d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);

            listBoxTop10.BackColor = color;
            listViewOrders.BackColor = color;

            listViewOrders.ForeColor = System.Drawing.Color.White;
            listBoxTop10.ForeColor = System.Drawing.Color.White;



            hex = "#020b0d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            btnOrderRep.BackColor = color;
            btnOrderRep.ForeColor = System.Drawing.Color.White;

            btnTop10Rep.BackColor = color;
            btnTop10Rep.ForeColor = System.Drawing.Color.White;

            
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
