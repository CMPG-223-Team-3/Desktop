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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        private void deleteOrderID(int orderID)
        {
          string queryDelete = "DELETE FROM Orders WHERE OrderID = '"+orderID+"'";
        }

        private void deleteOrderTable(int tableNum)
        {
            string queryDelete = "DELETE FROM Orders WHERE Table_nr = '" + tableNum + "'";
        }

        private void updateOrder(int orderID, DateTime orderTime ,DateTime orderDate,int table,int paid,int cashOrCard,int waiterID)
        {
            string queryUpdate = "UPDATE Orders SET Order_Date='"+orderDate+"',Order_Time='"+orderTime+"',Table_nr='"+table+"',WaiterID='"+waiterID+"',Paid='"+paid+"',CashOrCard ='"+cashOrCard+"' WHERE OrderID='"+orderID+"'";
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
        }
    }
}
