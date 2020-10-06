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
            myPanels.Add("Login", LoginPanel);

            foreach(KeyValuePair<string, Panel> kvp in myPanels)
            {
                kvp.Value.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
