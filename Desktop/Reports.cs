using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void top10(DateTime beginDate, DateTime endDate, DateTime beginTime, DateTime endTime)
        {

            string top10Rquery = " SELECT * FROM ORDER_DETAIL";

        }

        private void orders(DateTime beginDate , DateTime endDate , DateTime beginTime, DateTime endTime)
        {
            string orderRquery = "SELECT * FROM ORDERS where Order_Date >= '"+ beginDate + "' AND Order_Date <= '" + endDate + "' AND Order_Time >= '" + beginTime + "' AND Order_Time <= '" + endTime + "' ";
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
