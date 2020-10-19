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
    public partial class Locations : Form
    {
        private Desktop myMainForm;
        public Locations(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
    }
}
