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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private void addStaff(string first, string last,string username, string password)
        {
            string queryAdd = "INSERT INTO Waiters (Firstname,Lastname,Username,Password) Values ('"+first+"','"+last+"','"+username+"','"+password+"')";
        }

        private void updateStaff(int staffID, string first, string last, string username, string password)
        {
            string queryUpdate = "UPDATE Waiters SET Firstname='" + first + "',Lastname='" + last + "',Username='" + username + "',Password='" + password + "' WHERE Staff_ID= '"+staffID+"'" ;
        }

        private void deleteStaff(int staffID)
        {
            string queryDelete = "DELETE FROM Orders WHERE Table_nr = '" + staffID + "'";
        }
        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
