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
        IDictionary<string, Form> myForms = new Dictionary<string, Form>();
        public Desktop()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.Machine) ?? string.Empty;


            myForms.Add("Categories", new Categories());
            myForms.Add("Customers", new Customers());
            myForms.Add("Database", new Database());
            myForms.Add("Locations", new Locations());
            myForms.Add("Login", new Login());
            myForms.Add("Menu Items", new Menu_Items());
            myForms.Add("Orders", new Orders());
            myForms.Add("Positions", new Positions());
            myForms.Add("Recipes", new Recipes());
           // myForms.Add("Login", new Login());
            myForms.Add("Stock", new Stock());
            myForms.Add("Suppliers", new Suppliers());
            myForms.Add("Worklog", new Worklog());

            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                kvp.Value.MdiParent = this;
                kvp.Value.StartPosition = FormStartPosition.CenterScreen;
            }

            myForms["Login"].Show();
        }

        private void HideAllForms(string nextFormKey)
        {
            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                if (!kvp.Key.Equals(nextFormKey))
                { 
                    kvp.Value.Hide(); 
                }
            }
        }
    }
}
