using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Customer_View_Orders : Form
    {

        Controller controllerDB;
        string Cust_ID;

        public Customer_View_Orders()
        {
            InitializeComponent();
        }

        public Customer_View_Orders(string id)
        {
            InitializeComponent();
            Cust_ID = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_View_Orders_Load(object sender, EventArgs e)
        {
            controllerDB = new Controller();
            DataTable DT = controllerDB.GetNumberofOrdersForSelectedCustomer(Cust_ID);
            OrderCount_Label.Text = DT.Rows[0][0].ToString();
            controllerDB = new Controller();
            DT = controllerDB.GetOrdersforSelectedCustomer(Cust_ID);
            dataGridView1.DataSource = DT;
            dataGridView1.Refresh();
        }
    }
}
