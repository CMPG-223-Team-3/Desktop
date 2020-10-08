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
        IDictionary<string, Panel> myPanels = new Dictionary<string, Panel>();
        public Desktop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string server = System.Environment.GetEnvironmentVariable("CMPG223SERVER", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string database = System.Environment.GetEnvironmentVariable("CMPG223DATABASE", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string uid = System.Environment.GetEnvironmentVariable("CMPG223UID", EnvironmentVariableTarget.Machine) ?? string.Empty;
            string password = System.Environment.GetEnvironmentVariable("CMPG223PASSWORD", EnvironmentVariableTarget.Machine) ?? string.Empty;
            
            
            myPanels.Add("Login", LoginPanel);

            foreach(KeyValuePair<string, Panel> kvp in myPanels)
            {
                kvp.Value.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
