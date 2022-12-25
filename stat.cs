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
            chart3.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chart1.Visible == false)
            {
                controllerobj = new Controller();
                dt = controllerobj.groupproducts();
                if (dt != null)
                {
                    chart2.Hide();
                    chart3.Hide();
                    chart1.Show();
                    chart1.DataSource = dt;
                    chart1.Series["Products"].XValueMember = "Name";
                    chart1.Series["Products"].YValueMembers = "Quantity";
                    chart1.Titles.Add("Total Sold Products");
                    chart1.DataBind();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void stat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chart2.Visible == false)
            {
                controllerobj = new Controller();
                dt2 = controllerobj.grouporders();
                if (dt2 != null)
                {
                    chart1.Hide();
                    chart3.Hide();
                    chart2.Show();
                    chart2.DataSource = dt2;
                    chart2.Series["Order"].XValueMember = "Country";
                    chart2.Series["Order"].YValueMembers = "Number of Orders";
                    chart2.Titles.Add("Most Countries Buying Products");
                    chart2.DataBind();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chart3.Visible == false)
            {
                controllerobj = new Controller();
                dt2 = controllerobj.groupsuppliers();
                if (dt2 != null)
                {
                    chart1.Hide();
                    chart2.Hide();
                    chart3.Show();
                    chart3.DataSource = dt2;
                    chart3.Series["Suppliers"].XValueMember = "Name";
                    chart3.Series["Suppliers"].YValueMembers = "Number of Materials";
                    chart3.Titles.Add("Number of Materials Supplied Per Supplier");
                    chart3.DataBind();
                }
            }
        }
    }
}
