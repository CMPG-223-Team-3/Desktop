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


            myForms.Add("Login", new Login());

            foreach(KeyValuePair<string, Form> kvp in myForms)
            {
                kvp.Value.MdiParent = this;
            }

            myForms["Login"].StartPosition = FormStartPosition.CenterScreen;

            myForms["Login"].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
