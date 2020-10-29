using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Orders : Form
    {

        private MySqlConnection connection;
        private string server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
        private string database = "CMPG_223_DB";
        private string uid = "admin";
        private string password = "cmpg22310";
        string connectionstring;
        private Desktop myMainForm;
        public Orders(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
        private void deleteOrderID(int orderID)
        {
            string queryDelete = "DELETE FROM ORDERS WHERE Order_ID = '" + orderID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

            string query2Delete = "DELETE FROM ORDER-DETAIL WHERE Order_ID = '" + orderID + "'";
            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteOrderTable(int tableNum)
        {
            string queryDelete = "DELETE FROM ORDERS WHERE Table_nr = '" + tableNum + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateOrder(int orderID, DateTime orderDateTime, int table, int paid, int cashOrCard, int waiterID, int status, int quant)
        {
            string queryUpdate = "UPDATE ORDER SET Order_Date_Time='" + orderDateTime + "',Table_nr='" + table + "',Waiter_ID='" + waiterID + "',Paid='" + paid + "',CashOrCard ='" + cashOrCard + "',Status ='" + cashOrCard + "' WHERE Order_ID='" + orderID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

            int menuID = 0;
            string query = "SELECT * FROM ORDER-DETAIL WHERE = '"+orderID+"'";
            //open connection
            connection.Open();
            //put in comand
            cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                menuID=int.Parse(dataR["MenuItemID"]+"");
            }
            // close data reader
            dataR.Close();
            // close connection
            connection.Close();


            int unitPrice = 0;

            query = "SELECT * FROM MENU_ITEM";
            //open connection
            connection.Open();
            //put in comand
             cmd = new MySqlCommand(query, connection);
              dataR= cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                unitPrice= int.Parse(dataR["Price"]+"");
            }
            // close data reader
            dataR.Close();
            // close connection
            connection.Close();

            double pricePaid = unitPrice*quant;
            string query2Update = "UPDATE ORDER DETAIL SET Quantity_Ordered='" + quant + "', Price_Paid='"+pricePaid+"' WHERE Order_ID='" + orderID + "'";
            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();


        }

        private void Orders_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid
                 + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);


            lblCashorCard.ForeColor = System.Drawing.Color.White;
            lblDate.ForeColor = System.Drawing.Color.White;
            lblPaid.ForeColor = System.Drawing.Color.White;
            lblQuant.ForeColor = System.Drawing.Color.White;
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblWaiter.ForeColor = System.Drawing.Color.White;
            lblOrderID.ForeColor = System.Drawing.Color.White;
            lblTable.ForeColor = System.Drawing.Color.White;
            lblOrderHeading.ForeColor = System.Drawing.Color.White;


            comboBoxCashorCard.ForeColor = System.Drawing.Color.White;
            comboBoxDeleteOrderID.ForeColor = System.Drawing.Color.White;
            comboBoxOrderID.ForeColor = System.Drawing.Color.White;
            comboBoxPaid.ForeColor = System.Drawing.Color.White;
            comboBoxStatus.ForeColor = System.Drawing.Color.White;
            comboBoxCashorCard.ForeColor = System.Drawing.Color.White;
            dateTimePickerOrder.ForeColor = System.Drawing.Color.White;

            textBoxQuant.ForeColor = System.Drawing.Color.White;
            textBoxTable.ForeColor = System.Drawing.Color.White;
            textBoxWaiter.ForeColor = System.Drawing.Color.White;



            string hex = "#536878";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            this.BackColor = color;

            comboBoxCashorCard.BackColor = color;
            comboBoxDeleteOrderID.BackColor = color;
            comboBoxOrderID.BackColor = color;
            comboBoxPaid.BackColor = color;
            comboBoxStatus.BackColor = color;
            comboBoxCashorCard.BackColor = color;

            textBoxQuant.BackColor = color;
            textBoxTable.BackColor = color;
            textBoxWaiter.BackColor = color;
            hex = "#19262d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            
            tabPageDeleteOrder.ForeColor = System.Drawing.Color.White;
            tabPageUpOrders.ForeColor = System.Drawing.Color.White;
            tabPageDeleteOrder.BackColor = color;
            tabPageUpOrders.BackColor = color;



            hex = "#020b0d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
           
            btnConfirmDelete.BackColor = color;
            btnConfirmDelete.ForeColor = System.Drawing.Color.White;

            btnConfirmUP.BackColor = color;
            btnConfirmUP.ForeColor = System.Drawing.Color.White;




        }

        private void comboBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM ORDER WHERE Order_ID '" + comboBoxDeleteOrderID.SelectedItem.ToString() + "'";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                textBoxTable.Text = dataR["Table_nr"] + "";
                textBoxWaiter.Text = dataR["Waiter_ID"] + "";

                dateTimePickerOrder.Value = DateTime.Parse(dataR["Order_Date_Time"] + "");

                comboBoxPaid.SelectedItem = dataR["Paid"] + "";
                comboBoxCashorCard.SelectedItem = dataR["CashOrCard"] + "";
                comboBoxStatus.SelectedItem = dataR["Status"] + "";
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBoxOrderID_Click(object sender, EventArgs e)
        {
            comboBoxDeleteOrderID.Items.Clear();
            string query = "SELECT * FROM `ORDER`";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxOrderID.Items.Add(dataR["Order_ID"]+"");
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBoxPaid_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxCashorCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCashorCard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmUP_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(comboBoxOrderID.SelectedItem.ToString());
                DateTime date = dateTimePickerOrder.Value;// check this later on 
                bool tableVal = false;
                bool empty = true;

                if ((textBoxQuant.Text=="")|| (textBoxTable.Text =="")|| (textBoxWaiter.Text ==""))
                {
                    MessageBox.Show("Can not submit empty values");
                }
                else
                {
                    empty = false;
                }
                if (int.TryParse(textBoxTable.Text, out int table))
                    tableVal = true;
                else
                {
                    //error message
                    MessageBox.Show("Table needs to be a number");
                    textBoxTable.Focus();

                }
                bool waiterVal = false;
                if (int.TryParse(textBoxWaiter.Text, out int waiter))
                    waiterVal = true;
                else
                { //error message
                    MessageBox.Show("Waiter ID needs to be a number");
                    textBoxWaiter.Focus();

                }
                bool quantVal = false;
                if (int.TryParse(textBoxQuant.Text, out int quant))
                {
                    quantVal = true;

                }
                else
                {
                    MessageBox.Show("Quantity needs to be a number");
                    textBoxQuant.Focus();
                }



                int paid = int.Parse(comboBoxPaid.SelectedItem.ToString());
                int paidStatus = int.Parse(comboBoxCashorCard.SelectedItem.ToString());
                int status = int.Parse(comboBoxStatus.SelectedItem.ToString());


                if ((waiterVal) && (tableVal)&&(quantVal) &&( !empty))
                {
                    updateOrder(orderID, date, table, waiter, paid, paidStatus, status, quant);
                    MessageBox.Show("Order has been updated");

                }
            }
            catch
            {
                MessageBox.Show("Order could not be updated");

            }


        }

        private void comboBoxDeleteOrderID_Click(object sender, EventArgs e)
        {
            comboBoxDeleteOrderID.Items.Clear();
            string query = "SELECT * FROM `ORDER`";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteOrderID.Items.Add(dataR["Order_ID"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

      

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {

            
            try
            {
                int deleteID = int.Parse(comboBoxDeleteOrderID.SelectedItem.ToString());

                deleteOrderID(deleteID);

                MessageBox.Show("Order has been deleted");
            }
            catch
            {
                MessageBox.Show("Order could not be deleted");
            }





        }

        private void comboBoxDeleteOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myMainForm.switchTo("MainForm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuant_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWaiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWaiter_Click(object sender, EventArgs e)
        {

        }

        private void lblCashorCard_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
