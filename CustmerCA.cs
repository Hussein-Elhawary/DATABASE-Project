using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class CustmerCA : Form
    {
        public CustmerCA()
        {
            InitializeComponent();
        }
        private void Con_Button_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text.Length < 1)
            {
                label13.Text = "Please Enter Your First Name!";
                return;
            }

            if (maskedTextBox2.Text.Length < 1)
            {
                label13.Text = "Please Enter Your Middle Name!";
                return;
            }

            if (maskedTextBox5.Text.Length < 1)
            {
                label13.Text = "Please Enter Your Last Name!";
                return;
            }

            if (City_Box.Text.Length < 1)
            {
                label13.Text = "Please Enter Your City!";
                return;
            }

            if (maskedTextBox3.Text.Length < 1)
            {
                label13.Text = "Please Enter Your Address!";
                return;
            }

            if (maskedTextBox4.Text.Length < 1)
            {
                label13.Text = "Please Enter An E-mail!";
                return;
            }

            if (Ccode_textbox.Text.Length < 1)
            {
                label13.Text = "Please Enter a valid Country Code!";
                return;
            }

            if (maskedTextBox7.Text.Length < 11)
            {
                label13.Text = "Please Enter a valid Phone Number!";
                return;
            }

            if (maskedTextBox1.Text.Length < 1)
            {
                label13.Text = "Please Enter Your Prefered Delivery Time!";
                return;
            }

            label13.Text = "";

            createuser a = new createuser(maskedTextBox1.Text,maskedTextBox2.Text,maskedTextBox5.Text,comboBox1.SelectedItem.ToString(),City_Box.Text,maskedTextBox3.Text,maskedTextBox4.Text,Ccode_textbox.Text,maskedTextBox7.Text.ToString(),dateTimePicker1.Text,comboBox4.SelectedIndex,maskedTextBox6.Text);
            this.Hide();
            a.Show();
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

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CustmerCA_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            welcome a = new welcome();
            this.Hide();
            a.Show();
        }
    }
}
