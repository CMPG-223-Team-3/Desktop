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
        }
    }
}
