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
    public partial class Orders : Form
    {

        private MySqlConnection connection;
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
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

            string query2Delete = "DELETE FROM ORDER DETAIL WHERE Order_ID = '" + orderID + "'";
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

        private void updateOrder(int orderID, DateTime orderDateTime, int table, int paid, int cashOrCard, int waiterID,int status ,int quant )
        {
            string queryUpdate = "UPDATE ORDERS SET Order_DateTime='" + orderDateTime + "',Table_nr='" + table + "',Waiter_ID='" + waiterID + "',Paid='" + paid + "',CashOrCard ='" + cashOrCard +  "',Status ='" + cashOrCard + "' WHERE Order_ID='" + orderID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();

            string query2Update = "UPDATE ORDER DETAIL SET Quantity_Ordered='" + quant + "' WHERE Order_ID='" + orderID + "'";
            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                 + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);


        }

        private void comboBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ORDERS WHERE Order_ID '" + int.Parse(comboBoxDeleteOrderID.SelectedItem.ToString()) + "'";
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

                dateTimePickerOrder.Value = DateTime.Parse(dataR["Order_DateTime"] + "");

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
            string query = "SELECT * FROM ORDERS";
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

        private void comboBoxPaid_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ORDERS";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteOrderID.Items.Add(dataR["Paid"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBoxCashorCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCashorCard_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ORDERS";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteOrderID.Items.Add(dataR["CheckOrCash"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void btnConfirmUP_Click(object sender, EventArgs e)
        {
            try {
                int orderID = int.Parse(comboBoxOrderID.SelectedItem.ToString());
                DateTime date = dateTimePickerOrder.Value;// check this later on 
                bool tableVal = false;
                
                
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
                

                if (waiterVal && tableVal)
                {
                    updateOrder(orderID, date, table, waiter, paid, paidStatus,status,quant);
                    MessageBox.Show("Order has been updated");

                }
            }
            catch {
                MessageBox.Show("Order could not be updated");
            
            }
            

        }

        private void comboBoxDeleteOrderID_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ORDERS";
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

        private void comboBoxDeleteTable_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ORDERS";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteOrderID.Items.Add(dataR["Table_nr"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try {
                int deleteID = int.Parse(comboBoxDeleteOrderID.SelectedItem.ToString());

                deleteOrderID(deleteID);

                MessageBox.Show("Order has been deleted");
            }
            catch {
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
    }
}
