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
        private Desktop myMainForm;
        string server;
        string database;
        string uid;
        string password;
        string port;

        public Database(ref Desktop MainForm)
        {
            InitializeComponent();

            this.myMainForm = MainForm;


            server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.User) ?? "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
            database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.User) ?? "sql7368973";
            uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.User) ?? "admin";
            password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.User) ?? "cmpg22310";
            port = System.Environment.GetEnvironmentVariable("CMPG223PORT", EnvironmentVariableTarget.User) ?? "3306";

            txtServerAddress.Text = server;
            txtSchema.Text = database;
            txtUsername.Text = uid;
            txtPassword.Text = password;
            txtServerPort.Text = port;
        }

        public bool testConnection()
        {
            server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.User) ?? "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
            database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.User) ?? "sql7368973";
            uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.User) ?? "admin";
            password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.User) ?? "cmpg22310";
            port = System.Environment.GetEnvironmentVariable("CMPG223PORT", EnvironmentVariableTarget.User) ?? "3306";


            return testConnection(server, port, database, uid, password);
        }

        public bool testConnection(String server, String port, String database, String uid, String password)
        {
            string connectionString = "SERVER = " + server + "; DATABASE = " + database + "; UID = " + uid + "; PASSWORD = " + password + "; PORT = " + port + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            server = txtServerAddress.Text;
            port = txtServerPort.Text;
            database = txtSchema.Text;
            uid = txtUsername.Text;
            password = txtPassword.Text;

            if (testConnection(server, port, database, uid, password))
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Unable to connect");
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            System.Environment.SetEnvironmentVariable("CMPG223SERVER", txtServerAddress.Text, EnvironmentVariableTarget.User);
            System.Environment.SetEnvironmentVariable("CMPG223DATABASE", txtSchema.Text, EnvironmentVariableTarget.User);
            System.Environment.SetEnvironmentVariable("CMPG223UID", txtUsername.Text, EnvironmentVariableTarget.User);
            System.Environment.SetEnvironmentVariable("CMPG223PASSWORD", txtPassword.Text, EnvironmentVariableTarget.User);
            System.Environment.SetEnvironmentVariable("CMPG223PORT", txtServerPort.Text, EnvironmentVariableTarget.User);

            server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.User) ?? "cmpg-223-db.ci6pbvbzz3x3.us-west-1.rds.amazonaws.com";
            database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.User) ?? "sql7368973";
            uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.User) ?? "admin";
            password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.User) ?? "cmpg22310";
            port = System.Environment.GetEnvironmentVariable("CMPG223PORT", EnvironmentVariableTarget.User) ?? "3306";

            txtServerAddress.Text = server;
            txtSchema.Text = database;
            txtUsername.Text = uid;
            txtPassword.Text = password;
            txtServerPort.Text = port;

            MessageBox.Show("Server info saved");
        }
    }
}
