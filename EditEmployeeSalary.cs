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
    public partial class EditEmployeeSalary : Form
    {
        string username;
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt1 = null;
        DataTable dt4 = null;
        public EditEmployeeSalary(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
            dt = controllerobj.filldepartements();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox4.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt1 = controllerobj.fillemployeebydept(value);
            if (dt1 != null)
            {
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "First name";
                comboBox1.ValueMember = "Employee ID";
                maskedTextBox1.Text = dt1.Rows[0]["Employee ID"].ToString();
                maskedTextBox2.Text = dt1.Rows[0]["Fixed salary"].ToString();
            }
            else
            {
                comboBox1.DataSource = dt1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedValue.ToString();
            string newsalary = maskedTextBox3.Text;

            if (id == "")
            {
                MessageBox.Show("Please Select An Employee!");
            }
            else if (newsalary == "")
            {
                MessageBox.Show("Please Enter The New Salary");
            }
            else
            {
                controllerobj = new Controller();
                int valuee = controllerobj.Editsalary(newsalary, id);
                if (valuee == 1)
                {
                    MessageBox.Show("Update Is Done");
                    maskedTextBox3.ResetText();
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            EmployeeHomepage eh = new EmployeeHomepage(username,username[0]);
            eh.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }
    }
}
