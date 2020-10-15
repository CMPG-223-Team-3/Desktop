using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string server;
            string database;
            string uid;
            string password;
            string port;

            server = "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
            port = "3306";
            database = "sql7368973";
            uid = "admin";
            password = "cmpg22310";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Port=" + port+";" + "Database=" +
            database + ";" + " Uid=" + uid + ";" + "pwd=" + password + ";";

            conn = new MySqlConnection(connectionString);
            conn.Open();
            conn.Close();
        }
    }
}
