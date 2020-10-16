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
    public partial class Menu_Items : Form
    {
        private Desktop myMainForm;
        public Menu_Items(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }

        private void Menu_Items_Load(object sender, EventArgs e)
        {

        }
    }
}
