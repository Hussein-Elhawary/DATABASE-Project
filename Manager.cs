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
            f = new welcome();
            t = new Personal_Data();
            b = new AddBranch(username);
            p = new EditPDE(username);
            v = new ViewProjects();
            controllerobj = new Controller();
            dt = controllerobj.SelectFirstName(username);
            label2.Text = dt.Rows[0][0].ToString(); //Manager First name appears
            dt3 = controllerobj.SelectDepartment(username);//query returns id 
            dt2 = controllerobj.SelectEmployeeFirstNameFromDepartmentid(Convert.ToInt32(dt3.Rows[0][0])); //gets employees first name from a specific department
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "First name";
            comboBox2.DisplayMember = "First name";
            // dt2 = controllerobj.SelectProjectName(Convert.ToInt32(dt3.Rows[0][0]));
           // comboBox1.DisplayMember = "Name";
           // comboBox1.ValueMember = "Name";
            textBox1.Enabled = false;
            comboBox4.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;

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
            if (comboBox5.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                E = new ViewEmployees(comboBox2.Text.ToString(), comboBox4.Text.ToString(), comboBox5.Text.ToString()) ;
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
            if(textBox1.Text!=null)
            {
                // controllerobj.           //update salary using names
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox4.Enabled = true;
                dt2 = controllerobj.SelectEmployeeMiddleNameFromFirstName(comboBox2.SelectedText.ToString()); //gets employees first name from a specific department
                comboBox4.DataSource = dt2;
                comboBox4.ValueMember = "Middle name";
                comboBox4.DisplayMember = "Middle name";
            
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedText.ToString() != null)
            {
                dt2 = controllerobj.SelectEmployeeLastName(comboBox2.SelectedText.ToString(), comboBox4.SelectedText.ToString()); //gets employees first name from a specific department
                comboBox5.DataSource = dt2;
                comboBox5.ValueMember = "Last name";
                comboBox5.DisplayMember = "Last name";
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
       
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
    }
}
