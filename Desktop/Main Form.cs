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

            menuStrip1.ForeColor =  System.Drawing.Color.White;
            menuStrip1.BackColor =   System.Drawing.Color.Black;
            //GUI

            string hex = "#0b1013";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            
            this.BackColor = color;


            Desktop myMainForm = this;

            /*string server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string port = System.Environment.GetEnvironmentVariable("CMPG223PORT", EnvironmentVariableTarget.Machine) ?? "3306";*/

            myForms.Add("Database", new Database(ref myMainForm));
            myForms.Add("Login", new Login(ref myMainForm));
            myForms.Add("Staff", new Staff(ref myMainForm));
            myForms.Add("Reports", new Reports(ref myMainForm));
            myForms.Add("Orders", new Orders(ref myMainForm));
            myForms.Add("MenuItems", new MenuItems(ref myMainForm));


            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                kvp.Value.MdiParent = this;
                kvp.Value.StartPosition = FormStartPosition.CenterScreen;
            }

            if(((Database)myForms["Database"]).testConnection())
            {
                this.switchTo("Login");
            }
        }

        public void switchTo(string nextFormKey)
        {
            foreach (KeyValuePair<string, Form> kvp in myForms)
            {
                if (!kvp.Key.Equals(nextFormKey))
                {
                    kvp.Value.Hide();
                }
                else
                {
                    kvp.Value.Show();
                }
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo("Database");
        }

        private void waitersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo("Staff");
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo("Orders");
        }

        private void menuItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo("MenuItems");
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo("Reports");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //GUI

        /*string hex = "#536878";
        Color color = System.Drawing.ColorTranslator.FromHtml(hex);
        this.BackColor = color;*/

        


    }
}
