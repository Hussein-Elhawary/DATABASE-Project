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
            string user = maskedTextBox10.Text;
            string fname = maskedTextBox1.Text;
            string mname = maskedTextBox2.Text;
            string lname = maskedTextBox5.Text;
            string mail = maskedTextBox4.Text;
            //string gender = comboBox3.SelectedText;
            string NID = maskedTextBox8.Text;
            string PN = maskedTextBox7.Text;
            //string nation = comboBox5.SelectedItem.ToString();
            string id = maskedTextBox8.Text;
            string BD = monthCalendar1.Text;
            string salary = maskedTextBox6.Text;
            string IP = maskedTextBox11.Text;
            string branch = comboBox2.SelectedValue.ToString();
            string spe = maskedTextBox3.Text;
            string dept = comboBox4.SelectedValue.ToString();
            string password = maskedTextBox9.Text;

            if (password == "")
            {

            }
            else
            {
                string sendpass = Encrypt(maskedTextBox9.Text);
                controllerobj = new Controller();
                int resu = controllerobj.addnewEmployee(id, PN, mail, user, sendpass, "0", "0", "0", fname, mname, lname, "true", spe, salary, BD, "00", IP, dept, branch);
                if (resu == 1)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
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
    }
}
