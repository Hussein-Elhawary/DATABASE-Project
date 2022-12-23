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
    public partial class ViewRequestCustomerSide : Form
    {
        Controller ControllerObj;
        string Cust_ID;

        public ViewRequestCustomerSide()
        {
            InitializeComponent();
        }

        public ViewRequestCustomerSide(string C_ID)
        {
            InitializeComponent();
            Cust_ID = C_ID;
        }

        private void ViewRequestCustomerSide_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            ControllerObj = new Controller();
            DataTable DT = ControllerObj.CustomerViewRequest(Cust_ID);
            dataGridView1.DataSource = DT;
        }
    }
}
