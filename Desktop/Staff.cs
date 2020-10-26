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
        private string server = "sql7.freemysqlhosting.net";
        private string database = "sql7368973";
        private string uid = "sql7368973";
        private string password = "1lFxsKtjXr";
        string connectionstring;
        private Desktop myMainForm ;
        public Staff(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
        private void addStaff(string first, string last, string username, string password)
        {
            string queryAdd = "INSERT INTO Waiters (Firstname,Lastname,Username,Password) Values ('" + first + "','" + last + "','" + username + "','" + password + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryAdd;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateStaff(int staffID, string first, string last, string username, string password)
        {
            string queryUpdate = "UPDATE Waiters SET Firstname='" + first + "',Lastname='" + last + "',Username='" + username + "',Password='" + password + "' WHERE Staff_ID= '" + staffID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryUpdate;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteStaff(int staffID)
        {
            string queryDelete = "DELETE FROM Orders WHERE Table_nr = '" + staffID + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = queryDelete;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            connectionstring = "SERVE=" + server + ";" + "DATABASE=" + database + ";" + "UID" + uid
                 + ";" + "PASSWORD" + password + ";";
            connection = new MySqlConnection(connectionstring);

            //GUI
            lblAddFirstname.ForeColor = System.Drawing.Color.White;
            lblAddLastname.ForeColor = System.Drawing.Color.White;
            lblAddPassword.ForeColor = System.Drawing.Color.White;
            lblAddUsername.ForeColor = System.Drawing.Color.White;
            lblPasswordUP.ForeColor = System.Drawing.Color.White;
            lblStaffUP.ForeColor = System.Drawing.Color.White;
            lblUPfirstname.ForeColor = System.Drawing.Color.White;
            lblUpLastname.ForeColor = System.Drawing.Color.White;
            lblUPuasername.ForeColor = System.Drawing.Color.White;
            lblStaffIDdelete.ForeColor = System.Drawing.Color.White;

            comboBoxDeleteStaffID.ForeColor = System.Drawing.Color.White;
            comboBoxStaffIDUP.ForeColor = System.Drawing.Color.White;
            tabPageAddStaff.ForeColor = System.Drawing.Color.White;
            tabPageDeleteStaff.ForeColor = System.Drawing.Color.White;
            tabPageUpStaff.ForeColor = System.Drawing.Color.White;

            string hexPayensGray = "#536878";

            Color color = System.Drawing.ColorTranslator.FromHtml(hexPayensGray);

            this.BackColor = color;

            tabPageAddStaff.BackColor = color;
            tabPageDeleteStaff.BackColor = color;
            tabPageUpStaff.BackColor = color;

            string hexNavy = "#000080";

            color = System.Drawing.ColorTranslator.FromHtml(hexNavy);

            btnAddStaff.ForeColor = System.Drawing.Color.White;
            btnAddStaff.BackColor = color;

            btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            btnDeleteStaff.BackColor = color;

            btnUpdateStaff.ForeColor = System.Drawing.Color.White;
            btnUpdateStaff.BackColor = color;
        }

        private void comboBoxDeleteStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeleteStaffID_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM STAFF";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxDeleteStaffID.Items.Add(dataR["Staff_ID"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void comboBoxStaffIDUP_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM STAFF";
            //open connection
            connection.Open();
            //put in comand
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataR = cmd.ExecuteReader();
            // data reader
            while (dataR.Read())
            {
                comboBoxStaffIDUP.Items.Add(dataR["Staff_ID"]);
            }
            // close data reader
            dataR.Close();
            // close connection 
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxAddFirstname.Text;
            string lastname = textBoxAddLastname.Text;
            string username = textBoxAddUsername.Text;
            string password = textBoxAddPassword.Text;


            try 
            {
                string test;
                string query = "SELECT * FROM STAFF WHERE Waiter_Firstname'"+name+"' AND Waiter_Lastname'"+lastname+ "' AND Username'"+username+"' AND Password '"+password+"'";
                //open connection
                connection.Open();
                //put in comand
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataR = cmd.ExecuteReader();
                // data reader
                while (dataR.Read())
                {
                    test = dataR["Firstname"] + "";
                }
                // close data reader
                dataR.Close();
                // close connection 
                connection.Close();

                MessageBox.Show("A Staff memeber with these details already exists");
            }
            catch
            {
                addStaff(name, lastname, username, password);
            }
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxDeleteStaffID.SelectedItem.ToString());
            deleteStaff(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxStaffIDUP.SelectedItem.ToString());
            string name = textBoxUPFirstName.Text;
            string lastname = textBoxUpLastname.Text;
            string password = textBoxPasswordUP.Text;
            string username = textBoxUPusername.Text;


            updateStaff(id, name, lastname, username, password);
        }
    }
}
