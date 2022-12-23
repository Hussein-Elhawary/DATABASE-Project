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
    public partial class OrderDetails : Form
    {
        Controller ControllerObj;
        string Order_Num;

        public OrderDetails()
        {
            InitializeComponent();
        }

        public OrderDetails(string order)
        {
            InitializeComponent();
            Order_Num = order;
        }

        private void OrderDetails_Load_1(object sender, EventArgs e)
        {
            ControllerObj = new Controller();
            DataTable DT = ControllerObj.ViewOrderDetails(Order_Num);
            dataGridView1.DataSource = DT;
            dataGridView1.ReadOnly = true;
        }
    }
}