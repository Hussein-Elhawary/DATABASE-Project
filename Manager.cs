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
        Controller controllerobj;
        welcome f;
        AddBranch b;
        ViewBranchesAndRequests Vb;
        EditPDE p;
        ViewProjects v;
        ViewEmployees E;
        string username;
        DataTable dt;
        DataTable dt2;
        int newrequestid;
        public Manager()
        {
            InitializeComponent();

         }
        public Manager(string us)
        {
            InitializeComponent();
            username = us;
            f = new welcome();
            b = new AddBranch(username);
            p = new EditPDE(username);
            dt = new DataTable();
            dt2 = new DataTable();
            controllerobj = new Controller();
            dt = controllerobj.SelectFirstName(username);
            label2.Text = dt.Rows[0][0].ToString(); //Manager First name appears
            dt = controllerobj.SelectDepartment(username);//query returns id 
            dt2 = controllerobj.SelectEmployeeFirstNameFromDepartmentid(Convert.ToInt32(dt.Rows[0][0])); //gets employees first name from a specific department
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "First name";
            comboBox2.DisplayMember = "First name";
            controllerobj = new Controller();
            dt2 = controllerobj.SelectProjectName(Convert.ToInt32(dt.Rows[0][0]));
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            textBox1.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
          
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
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b.Show();
           this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                v = new ViewProjects(username,comboBox1.Text.ToString());
                v.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error You must choose");
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                E = new ViewEmployees(comboBox2.Text.ToString(), comboBox4.Text.ToString(), comboBox5.Text.ToString(),username);
                E.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Error Some Info are missing");
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //numbers only
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //numbers only
                e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null && comboBox5.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                int r = 0;
                controllerobj = new Controller();
                 r=controllerobj.UpdateSalary(Convert.ToInt32(textBox1.Text), comboBox2.Text.ToString(), comboBox4.Text.ToString(), comboBox5.Text.ToString());         //update salary using names
                if (r != 0)
                    MessageBox.Show("Updated Successfully");
            }
            else
                MessageBox.Show("Error Some Info are missing");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox4.Enabled = true;
            controllerobj = new Controller();
                dt2 = controllerobj.SelectEmployeeMiddleNameFromFirstName(comboBox2.Text.ToString()); //gets employees second name from the first name 
                comboBox4.DataSource = dt2;                                //example mohamed ahmed and mohamed ibrahim we will use mohamed to get the second combobox to have ahmed and ibrahim only 
            comboBox4.ValueMember = "Middle name";
                comboBox4.DisplayMember = "Middle name";
            comboBox4.SelectedIndex = -1;
            comboBox5.Enabled = false;
            textBox1.Enabled = false;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox5.Enabled = true;
            controllerobj = new Controller();
            dt2 = controllerobj.SelectEmployeeLastName(comboBox2.Text.ToString(), comboBox4.Text.ToString()); //gets employees last name from middle
                comboBox5.DataSource = dt2;
            comboBox5.ValueMember = "Last name";
                comboBox5.DisplayMember = "Last name";
            comboBox5.SelectedIndex = -1;
            textBox1.Enabled = false;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Vb = new ViewBranchesAndRequests(username);
            Vb.Show();
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                controllerobj = new Controller();
                dt = controllerobj.SelectProjectid(comboBox1.Text.ToString());
                E = new ViewEmployees(username, Convert.ToInt32(dt.Rows[0][0]));
                E.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error You must choose");
          
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ViewInsurance i = new ViewInsurance(username);
            i.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==null|| textBox6.Text==null)
            {
                MessageBox.Show(" Some Data are missing ");
            }
            else
            {
                controllerobj = new Controller();
                dt = controllerobj.SelectMaxRequestID();
                newrequestid = 1 + Convert.ToInt32(dt.Rows[0][0]);
                dt = controllerobj.GetEmployeeIdFromUsername(username);
                int r = 0;
                r = controllerobj.InsertManagerRequest(newrequestid, textBox2.Text.ToString(), DateTime.Now.ToString("M-d-yyyy"), textBox6.Text.ToString(), "false","null", Convert.ToInt32(dt.Rows[0][0]));
                if (r != 0)
                    MessageBox.Show(" Your Request has been sent successfully ");
                else
                    MessageBox.Show(" Failed ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            dt = controllerobj.GetEmployeeIdFromUsername(username);
            Vb = new ViewBranchesAndRequests(username, Convert.ToInt32(dt.Rows[0][0]));
            Vb.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            E = new ViewEmployees(username);
            E.Show();
            this.Hide();
        }
    }
}
