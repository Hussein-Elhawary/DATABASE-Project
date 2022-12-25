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
    public partial class stat : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt2 = null;
        public stat()
        {
            InitializeComponent();
            chart1.Hide();
            chart2.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt = controllerobj.groupproducts();
            if (dt!=null)
            {
                chart2.Hide();
                chart1.Show();
                chart1.DataSource = dt;
                chart1.Series["Products"].XValueMember = "Product ID";
                chart1.Series["Products"].YValueMembers = "Qunantity";
                chart1.Titles.Add("Sold Products");
                chart1.DataBind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt2 = controllerobj.grouporders();
            if (dt2 != null)
            {
                chart1.Hide();
                chart2.Show();
                chart2.DataSource = dt2;
                chart2.Series["Order"].XValueMember = "Country";
                chart2.Series["Order"].YValueMembers = "Number of Orders";
                chart2.Titles.Add("Most Countries Buying Products");
                chart2.DataBind();
            }
        }
    }
}
