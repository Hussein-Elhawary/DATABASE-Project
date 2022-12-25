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
        Controller controllerobj;
        DataTable dt = null;
        DataTable dt2 = null;
        DataTable dt3 = null;
        DataTable dt4 = null;
        string username;
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
        public stat(string us)
        {
            InitializeComponent();
            username = us;
            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart3.Titles.Add("Materials Consumed");
            chart2.Titles.Add("Most Countries Buying Products");
            chart1.Titles.Add("Sold Products");
            chart4.Titles.Add("Number of Materials Supplied Per Supplier");
            controllerobj = new Controller();
            dt = controllerobj.SelectDepartment(username);
            if(Convert.ToInt32(dt.Rows[0][0])== 12321)
            {
                button4.Visible = false;
                RawMaterials.Visible = false;
            }
            else if(Convert.ToInt32(dt.Rows[0][0]) == 1463)
            {
                button3.Visible = false;
                button1.Visible = false;
            }
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
                    chart1.Hide();
                    chart2.Hide();
                    chart3.Hide();
                    chart4.Hide();
                    chart1.DataSource = dt;
                    chart1.Series["Products"].XValueMember = "Name";
                    chart1.Series["Products"].YValueMembers = "Quantity";

                    chart1.DataBind();
                    chart1.Show();
                }
            }
        }

        private void RawMaterials_Click(object sender, EventArgs e)
        {

           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (chart4.Visible == false)
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

        private void stat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = username.Substring(0, 1);
            if (str == "m" || str == "M")
            {
                Manager m1 = new Manager(username);
                m1.Show();
                this.Hide();
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (chart2.Visible == false)
            {
                controllerobj = new Controller();
                dt2 = controllerobj.grouporders();
                if (dt2 != null)
                {
                    chart2.Hide();
                    chart1.Hide();
                    chart3.Hide();
                    chart4.Hide();
                    chart2.DataSource = dt2;
                    chart2.Series["Order"].XValueMember = "Country";
                    chart2.Series["Order"].YValueMembers = "Number of Orders";
                    chart2.DataBind();
                    chart2.Show();
                }
            }
        }

        private void RawMaterials_Click_1(object sender, EventArgs e)
        {
            if (chart3.Visible == false)
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
        }
    }
}
