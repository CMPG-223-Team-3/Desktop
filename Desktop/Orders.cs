﻿using System;
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
    public partial class Orders : Form
    {
        private Desktop myMainForm;
        public Orders(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }
    }
}
