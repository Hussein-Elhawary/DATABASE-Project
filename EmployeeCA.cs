using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class EmployeeCA : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt1 = null;
        public EmployeeCA()
        {
            InitializeComponent();
            DataTable dt = null;
            dt = controllerobj.filldepartements();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
            controllerobj = new Controller();
            dt1 = controllerobj.fillbranch();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Branch District Address";
            comboBox2.ValueMember = "Branch Number";
        }

        static string Encrypt(string passbefore)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(passbefore));
                return Convert.ToBase64String(data);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("First Name is Empty !");
                return;
            }
            string fname = maskedTextBox1.Text;
            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Middle Name is Empty !");
                return;
            }
            string mname = maskedTextBox3.Text;
            if (maskedTextBox5.Text == "")
            {
                MessageBox.Show("Last Name is Empty !");
                return;
            }
            string lname = maskedTextBox5.Text;
            string Gender;
            if (comboBox1.SelectedIndex == 0)
            {
                Gender = "M";
            }
            else
            {
                Gender = "F";
            }
            string nation = comboBox5.SelectedItem.ToString();
            if (maskedTextBox8.Text == "")
            {
                MessageBox.Show("ID/Passport is Empty");
                return;
            }
            string Pass_NID = maskedTextBox8.Text;
            string B_Date = dateTimePicker1.Text;
            string dept = comboBox4.SelectedValue.ToString();
            if (maskedTextBox3.Text == "")
            {
                MessageBox.Show("Specialization is Empty !");
                return;
            }
            string specialization = maskedTextBox3.Text;
            if (maskedTextBox6.Text == "")
            {
                MessageBox.Show("Salary is Empty !");
                return;
            }
            string salary = maskedTextBox6.Text;
            string branch = comboBox2.SelectedValue.ToString();
            if (maskedTextBox10.Text == "")
            {
                MessageBox.Show("UserName is Empty !");
                return;
            }
            if (maskedTextBox10.Text[0] == 'f' || maskedTextBox10.Text[0] == 'g' || maskedTextBox10.Text[0] == 'p')
            {
                
            }
            else
            {
                MessageBox.Show("UserName must either start with an(f or p or g) !");
                    return;
            }
            string user = maskedTextBox10.Text;
            if (maskedTextBox9.Text.Length > 20 || maskedTextBox9.Text.Length < 8)
            {
                MessageBox.Show("Password Must be between 8 and 20 characters!");
                return;
            }
            string password = maskedTextBox9.Text;
            password = Encrypt(password);
            string COD = comboBox1.SelectedItem.ToString();
            if (maskedTextBox13.Text == "")
            {
                MessageBox.Show("City is Empty !");
                return;
            }
            string City = maskedTextBox13.Text;
            if (maskedTextBox12.Text == "")
            {
                MessageBox.Show("Address is Empty !");
                return;
            }
            string Address = maskedTextBox12.Text;
            if (maskedTextBox4.Text == "")
            {
                MessageBox.Show("E-mail is Empty !");
                return;
            }
            string Email = maskedTextBox4.Text;
            if (maskedTextBox7.Text == "")
            {
                MessageBox.Show("Phone Number is Empty !");
                return;
            }
            string Phone = maskedTextBox7.Text;
            if (maskedTextBox11.Text == "")
            {
                MessageBox.Show("Extention is Empty !");
                return;
            }
            string Extention = maskedTextBox11.Text;

            controllerobj = new Controller();
            DataTable DT = controllerobj.SelectMaxEmployeeID();
            int New_Emp_ID = Convert.ToInt32(DT.Rows[0][0]);
            New_Emp_ID++;


            int result = controllerobj.addnewEmployee(New_Emp_ID.ToString(),Phone,Email,user,password,City,Address,COD,fname,mname,lname,Gender,specialization,salary,B_Date,nation,Extention,dept,branch);
            if (result == 1)
            {
                MessageBox.Show("Added Successfully");
                this.Hide();
                welcome a = new welcome();
                a.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EmployeeCA_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
    }
}
