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
    public partial class Desktop : Form
    {
        public IDictionary<string, Form> myForms = new Dictionary<string, Form>();
        public Desktop()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Desktop myMainForm = this;

            string server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string port = System.Environment.GetEnvironmentVariable("CMPG223PORT", EnvironmentVariableTarget.Machine) ?? "3306";


            myForms.Add("Categories", new Categories(ref myMainForm));
            myForms.Add("Customers", new Customers(ref myMainForm));
            myForms.Add("Database", new Database(ref myMainForm));
            myForms.Add("Locations", new Locations(ref myMainForm));
            myForms.Add("Login", new Login(ref myMainForm));
            myForms.Add("Menu Items", new Menu_Items(ref myMainForm));
            myForms.Add("Orders", new Orders(ref myMainForm));
            myForms.Add("Positions", new Positions(ref myMainForm));
            myForms.Add("Recipes", new Recipes(ref myMainForm));
            myForms.Add("Stock", new Stock(ref myMainForm));
            myForms.Add("Suppliers", new Suppliers(ref myMainForm));
            myForms.Add("Worklog", new Worklog(ref myMainForm));

            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                kvp.Value.MdiParent = this;
                kvp.Value.StartPosition = FormStartPosition.CenterScreen;
            }

            myForms["Login"].Show();
        }

        public void HideAllForms(string nextFormKey)
        {
            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                if (!kvp.Key.Equals(nextFormKey))
                { 
                    kvp.Value.Hide(); 
                }
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms("Database");
            myForms["Database"].Show();
        }
    }
}
