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
    public partial class Staff : Form
    {
        private MySqlConnection connection;
        private string server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
        private string database = "CMPG_223_DB";
        private string uid = "admin";
        private string password = "cmpg22310";
        string connectionstring;
        private Desktop myMainForm ;
        public Staff(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
        private void addStaff(string first, string last, string username, string password)
        {
            string queryAdd = "INSERT INTO WAITER (Waiter_Firstname,Waiter_Lastname,Username,Password) Values ('" + first + "','" + last + "','" + username + "','" + password + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryAdd;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateStaff(int staffID, string first, string last, string username, string password)
        {
            string queryUpdate = "UPDATE WAITER SET Waiter_Firstname='" + first + "',Waiter_Lastname='" + last + "',Username='" + username + "',Password='" + password + "' WHERE Waiter_ID= '" + staffID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteStaff(int staffID)
        {
            string queryDelete = "DELETE FROM WAITER WHERE Waiter_ID = '" + staffID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid
                 + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            lblStaffIDdelete.ForeColor = System.Drawing.Color.White;
            lblAddFirstname.ForeColor = System.Drawing.Color.White;
            lblAddLastname.ForeColor = System.Drawing.Color.White;
            lblAddUsername.ForeColor = System.Drawing.Color.White;
            lblAddPassword.ForeColor = System.Drawing.Color.White;
            lblStaffUP.ForeColor = System.Drawing.Color.White;
            lblUPfirstname.ForeColor = System.Drawing.Color.White;
            lblUpLastname.ForeColor = System.Drawing.Color.White;
            lblUPuasername.ForeColor = System.Drawing.Color.White;
            lblPasswordUP.ForeColor = System.Drawing.Color.White;
            lblStaffHeading.ForeColor = System.Drawing.Color.White;

            comboBoxDeleteStaffID.ForeColor = System.Drawing.Color.White;
            comboBoxStaffIDUP.ForeColor = System.Drawing.Color.White;

            textBoxAddFirstname.ForeColor = System.Drawing.Color.White;
            textBoxAddLastname.ForeColor = System.Drawing.Color.White;
            textBoxAddUsername.ForeColor = System.Drawing.Color.White;
            textBoxAddPassword.ForeColor = System.Drawing.Color.White;
            textBoxUPFirstName.ForeColor = System.Drawing.Color.White;
            textBoxUpLastname.ForeColor = System.Drawing.Color.White;
            textBoxUPusername.ForeColor = System.Drawing.Color.White;
            textBoxPasswordUP.ForeColor = System.Drawing.Color.White;



            string hex = "#536878";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            this.BackColor = color;

            comboBoxStaffIDUP.BackColor = color;
            comboBoxDeleteStaffID.BackColor = color;

         
            textBoxAddFirstname.BackColor = color;
            textBoxAddLastname.BackColor = color;
            textBoxAddUsername.BackColor = color;
            textBoxAddPassword.BackColor = color;
            textBoxUPFirstName.BackColor = color;
            textBoxUpLastname.BackColor = color;
            textBoxUPusername.BackColor = color;
            textBoxPasswordUP.BackColor = color;

            hex = "#19262d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            
            tabPageAddStaff.ForeColor = System.Drawing.Color.White;
            tabPageDeleteStaff.ForeColor = System.Drawing.Color.White;
            tabPageUpStaff.ForeColor = System.Drawing.Color.White;
            tabPageAddStaff.BackColor = color;
            tabPageDeleteStaff.BackColor = color;
            tabPageUpStaff.BackColor = color;




            hex = "#020b0d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            btnAddStaff.BackColor = color;
            btnAddStaff.ForeColor = System.Drawing.Color.White;

            btnDeleteStaff.BackColor = color;
            btnDeleteStaff.ForeColor = System.Drawing.Color.White;

            btnUpStaff.BackColor = color;
            btnUpStaff.ForeColor = System.Drawing.Color.White;
        }

        private void comboBoxDeleteStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeleteStaffID_Click(object sender, EventArgs e)
        {
            comboBoxDeleteStaffID.Items.Clear();
            string query = "SELECT * FROM WAITER";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteStaffID.Items.Add(dataR["Waiter_ID"]+"");
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBoxStaffIDUP_Click(object sender, EventArgs e)
        {
            comboBoxStaffIDUP.Items.Clear();
            string query = "SELECT * FROM WAITER";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxStaffIDUP.Items.Add(dataR["Waiter_ID"]+"");
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                string name = textBoxAddFirstname.Text;
                string lastname = textBoxAddLastname.Text;
                string username = textBoxAddUsername.Text;
                string password = textBoxAddPassword.Text;

                addStaff(name, lastname, username, password);
                MessageBox.Show("Waiter has been added");
            }
            catch
            {
                MessageBox.Show("Waiter could not be added");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int payed=0;
            int delivered=0;
            int orderID = 0;
            string query = "";
            bool can = false;
            bool contain = true;


            int id=0;
            // delete menu item
            try
            {
                // get order id
                id = int.Parse(comboBoxDeleteStaffID.SelectedItem.ToString());
                //open connection
                connection.Open();
                query = "SELECT * FROM `ORDER` WHERE Waiter_ID ='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataR = cmd.ExecuteReader();

                
                
                

                //put in comand
                cmd = new MySqlCommand(query, connection);
                dataR = cmd.ExecuteReader();
                // data reader
                while (dataR.Read())
                {

                   
                        payed = int.Parse(dataR["Paid"] + "");
                        delivered = int.Parse(dataR["Status"] + "");
                       



                    

                    dataR.Close();
                    // close connection
                    connection.Close();
                }
                // close data reader
                dataR.Close();
                // close connection
                
            }
            catch
            {
                contain = false;
            }

            connection.Close();



            if ((payed == 1 && delivered == 1)||!contain)
            {
                can = true;
            }
            else
            {
                can = false;
                MessageBox.Show("Connot delete Menu item , there ore orders with this item that are not payed and delivered");
            }


            try
            {

                if (can)

                {
                    deleteStaff(id);
                    MessageBox.Show("Waiter has been deleted");
                }
            }
            catch( Exception ew)
            {
                MessageBox.Show("Waiter could not be deleted. "+ew.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(comboBoxStaffIDUP.SelectedItem.ToString());
                string name = textBoxUPFirstName.Text;
                string lastname = textBoxUpLastname.Text;
                string password = textBoxPasswordUP.Text;
                string username = textBoxUPusername.Text;


                updateStaff(id, name, lastname, username, password);
                MessageBox.Show("Waiter has been updated");
            }
            catch
            {
                MessageBox.Show("Waiter could not be updated");
            }
            
        }

        private void comboBoxStaffIDUP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM WAITER WHERE Waiter_ID ='"+comboBoxStaffIDUP.SelectedItem.ToString()+"'";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                textBoxUPFirstName.Text = dataR["Waiter_Firstname"] + "";
                textBoxUpLastname.Text = dataR["Waiter_Lastname"] + "";
                textBoxUPusername.Text = dataR["Username"] + "";
                textBoxPasswordUP.Text = dataR["Password"] + "";

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

        private void lblStaffUP_Click(object sender, EventArgs e)
        {

        }
    }
}
