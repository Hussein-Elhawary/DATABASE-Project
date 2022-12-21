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
    public partial class Manager : Form
    {
        Controller controllerobj = new Controller();
        welcome f;
        Personal_Data t;
        AddBranch b;
        EditPDE p;
        ViewProjects v;
        ViewEmployees E;
        string username;
        DataTable dt;
        DataTable dt2;
        DataTable dt3;
        public Manager()
        {
            InitializeComponent();

            }
            public Manager(string us)
        {
            InitializeComponent();
            username = us;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            f = new welcome();
            t = new Personal_Data();
            b = new AddBranch();
            p = new EditPDE(username);
            v = new ViewProjects();
            E = new ViewEmployees();
            dt = controllerobj.SelectManagerName(username);
            label2.Text =dt.Rows[0][0].ToString(); //Manager First name appears
            dt3=controllerobj.SelectDepartment(username);//query returns id 
            dt2 = controllerobj.SelectEmployeeFirstNameFromDepartmentid(Convert.ToInt32(dt3.Rows[0][0])); //gets employees first name from a specific department
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "First name";
            comboBox2.DisplayMember = "First name";
            if(comboBox2.Text!=null)
            {
                comboBox4.Enabled = true; // to choose the middle name after you selected the first name
                dt2 = controllerobj.SelectEmployeeMiddleNameFromDepartmentid(Convert.ToInt32(dt3.Rows[0][0])); //gets employees first name from a specific department
                comboBox4.DataSource = dt2;
                comboBox4.ValueMember = "Middle name";
                comboBox4.DisplayMember = "Middle name";
                if (comboBox4.Text != null)
                {
                    comboBox5.Enabled = true; // to choose the middle name after you selected the first name
                    dt2 = controllerobj.SelectEmployeeLastNameFromDepartmentid(Convert.ToInt32(dt3.Rows[0][0])); //gets employees first name from a specific department
                    comboBox5.DataSource = dt2;
                    comboBox5.ValueMember = "Last name";
                    comboBox5.DisplayMember = "Last name";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            f.Show();
             this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            t.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b.Show();
           this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            v.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            E.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //numbers only
                e.Handled = true;
        }
    }
}
