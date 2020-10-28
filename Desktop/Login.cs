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
    public partial class Login : Form
    {
        int temp = 0;
        private Desktop myMainForm;
        private string pin = "2332";
        public Login(ref Desktop MainForm)
        {
            InitializeComponent();
            this.myMainForm = MainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputPin = txtNum1.Text + txtNum2.Text + txtNum3.Text + txtNum4.Text;

            if (pin==inputPin)
            {
                myMainForm.switchTo("MainForm");
                myMainForm.LogedIn();
            }
            else
            {
                MessageBox.Show("PIN is invalid");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string hex = "#536878";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            this.BackColor = color;

            lblHeading.ForeColor = System.Drawing.Color.White;
            lblPin.ForeColor = System.Drawing.Color.White;
            

            txtNum1.ForeColor = System.Drawing.Color.White;
            txtNum2.ForeColor = System.Drawing.Color.White;
            txtNum3.ForeColor = System.Drawing.Color.White;
            txtNum4.ForeColor = System.Drawing.Color.White;

            txtNum1.BackColor = color;
            txtNum2.BackColor = color;
            txtNum3.BackColor = color;
            txtNum4.BackColor = color;

            

            hex = "#02075d";
            color = System.Drawing.ColorTranslator.FromHtml(hex);
            btnLogin.BackColor = color;
            btnLogin.ForeColor = System.Drawing.Color.White;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            myMainForm.switchTo("Main Form");
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out temp))
            {
                txtNum1.Text = "";
            }

            if (txtNum1.Text.Length > 1)
            {
                txtNum1.Text = "";
            }

            if (txtNum1.Text.Length == 1)
            {
                txtNum2.Focus();
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum2.Text, out temp))
            {
                txtNum2.Text = "";
            }

            if (txtNum2.Text.Length > 1)
            {
                txtNum2.Text = "";
            }

            if (txtNum2.Text.Length == 1)
            {
                txtNum3.Focus();
            }
        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum3.Text, out temp))
            {
                txtNum3.Text = "";
            }

            if (txtNum3.Text.Length > 1)
            {
                txtNum3.Text = "";
            }

            if (txtNum3.Text.Length == 1)
            {
                txtNum4.Focus();
            }
        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum3.Text, out temp))
            {
                txtNum3.Text = "";
            }

            if (txtNum3.Text.Length > 1)
            {
                txtNum3.Text = "";
            }

            if (txtNum4.Text.Length == 1)
            {
                this.btnLogin_Click(sender, e);
            }
        }
    }
}
