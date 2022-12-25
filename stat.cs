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
        DataTable dt3 = null;
        DataTable dt4 = null;
        public stat()
        {
            InitializeComponent();
            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart3.Titles.Add("Materials Consumed");
            chart2.Titles.Add("Most Countries Buying Products");
            chart1.Titles.Add("Sold Products");
            chart4.Titles.Add("Number of Materials Supplied Per Supplier");
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
                chart1.Hide();
                chart2.Hide();
                chart3.Hide();
                chart1.DataSource = dt;
                chart1.Series["Products"].XValueMember = "Product ID";
                chart1.Series["Products"].YValueMembers = "Qunantity";

                chart1.DataBind();
                chart1.Show();
            }
        }

        private void RawMaterials_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt3 = controllerobj.groupRawMaterials();
            if (dt3 != null)
            {
                chart3.Hide();
                chart1.Hide();
                chart2.Hide();
                chart4.Hide();
                chart3.DataSource = dt3;
                chart3.Series["RawMaterials"].XValueMember = "Name";
                chart3.Series["RawMaterials"].YValueMembers = "Consumed Amount";             
                chart3.DataBind();
                chart3.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt2 = controllerobj.grouporders();
            if (dt2 != null)
            {
                chart2.Hide();
                chart1.Hide();
                chart3.Hide();
                chart2.DataSource = dt2;
                chart2.Series["Order"].XValueMember = "Country";
                chart2.Series["Order"].YValueMembers = "Number of Orders";
                chart2.DataBind();
                chart2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt4 = controllerobj.groupsuppliers();
            if (dt4 != null)
            {
                chart1.Hide();
                chart2.Hide();
                chart3.Hide();
                chart4.Hide();
                chart4.DataSource = dt4;
                chart4.Series["Suppliers"].XValueMember = "Name";
                chart4.Series["Suppliers"].YValueMembers = "Number of Materials";
                chart4.DataBind();
                chart4.Show();
            }
        }
    }
}
