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
    public partial class Personal_Data : Form
    {
        string username;
        DataTable dt = null;
        Controller controllerobj = new Controller();
        public Personal_Data()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.retrievePD(username);
            maskedTextBox7.Text = dt.Rows[0]["Phone"].ToString();
            maskedTextBox1.Text = dt.Rows[0]["First name"].ToString();
            maskedTextBox10.Text = username;
            textBox1.Text = username;
        }

        public Personal_Data(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Home h5 = new Home();
            h5.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w1 = new welcome();
            w1.Show();
            this.Hide();
        }

        private void Personal_Data_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
