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
            string queryDelete = "DELETE FROM Orders WHERE OrderID = '" + orderID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteOrderTable(int tableNum)
        {
            string queryDelete = "DELETE FROM Orders WHERE Table_nr = '" + tableNum + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateOrder(int orderID, DateTime orderTime, DateTime orderDate, int table, int paid, int cashOrCard, int waiterID)
        {
            string queryUpdate = "UPDATE Orders SET Order_Date='" + orderDate + "',Order_Time='" + orderTime + "',Table_nr='" + table + "',WaiterID='" + waiterID + "',Paid='" + paid + "',CashOrCard ='" + cashOrCard + "' WHERE OrderID='" + orderID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
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
            int orderID = int.Parse(comboBoxOrderID.SelectedItem.ToString()) ;
            DateTime date = dateTimePickerOrder.Value;// check this later on 
            bool tableVal = false;
            if (int.TryParse(textBoxTable.Text, out int table))
                tableVal = true;
            else
            {   
                //error message
            }
            bool waiterVal = false;
            if (int.TryParse(textBoxWaiter.Text, out int waiter))
                waiterVal = true;
            else
            { //error message

            }


            
            int paid = int.Parse(comboBoxPaid.SelectedItem.ToString());
            int paidStatus = int.Parse(comboBoxCashorCard.SelectedItem.ToString());
            if (waiterVal && tableVal)
            { 
                updateOrder(orderID, date, table:, waiter, paid, paidStatus);
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
            int deleteID = int.Parse(comboBoxDeleteOrderID.SelectedItem.ToString());

            deleteOrderID(deleteID);




        }
    }
}
