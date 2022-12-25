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
    public partial class EmployeeHomepage : Form
    {
        string username;
        char type;
        //general = g 
        //Finance = F
        //Production = P
      
        public EmployeeHomepage(string usernamec,char typec)
        {
            InitializeComponent();
            username = usernamec;
            type = typec;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
            button1.Visible = false;
            //button4.Visible = false;
            button6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            //label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            

            if (type=='g')
            {

            }
            else if (type=='f')
            {
                button6.Visible = true;
                label6.Visible = true;

            }
            else if (type == 'p')
            {
                button5.Visible = true;
                button1.Visible = true;
                //button4.Visible = true;
                //label4.Visible  = true;
                label5.Visible  = true;
                label7.Visible  = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPDE editPDE = new EditPDE(username);
            editPDE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewprojectE viewprojectE = new ViewprojectE(username);
            viewprojectE.Show();
            this.Hide();
            
        }

        private void EmployeeHomepage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeRawmaterials changeRawmaterials = new ChangeRawmaterials(username);
            changeRawmaterials.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditEmployeeSalary editEmployeeSalary = new EditEmployeeSalary(username);
            editEmployeeSalary.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct(username);
            editProduct.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewRawmaterials viewRawmaterials = new ViewRawmaterials(username);
            viewRawmaterials.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ViewInsurancebutton_Click(object sender, EventArgs e)
        {
            ViewInsurance vf = new ViewInsurance(username);
            vf.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w2 = new welcome();
            w2.Show();
            this.Close();
        }
    }
}
