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
        public EmployeeHomepage(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
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
    }
}
