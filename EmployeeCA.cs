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
    public partial class EmployeeCA : Form
    {
        Controller controllerobj = new Controller();
        public EmployeeCA()
        {
            InitializeComponent();
            DataTable dt = null;
            dt = controllerobj.filldepartements();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
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
            string fname = maskedTextBox1.Text;
            string mname = maskedTextBox2.Text;
            string lname = maskedTextBox5.Text;
            string mail = maskedTextBox4.Text;
            string gender = comboBox3.SelectedText;
            string NID = maskedTextBox8.Text;
            string PN = maskedTextBox7.Text;
            string nation = comboBox5.SelectedText;
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
    }
}
