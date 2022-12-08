using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EditPD : Form
    {
        public EditPD()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            CustomerHomePage a = new CustomerHomePage();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditPD_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            maskedTextBox13.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            maskedTextBox7.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;
            
            Confirm_Edits_Button.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboBox1.Enabled = true;
            maskedTextBox13.ReadOnly = false;
            maskedTextBox3.ReadOnly = false;
            Confirm_Edits_Button.Enabled = true;
            maskedTextBox7.ReadOnly = false;
            maskedTextBox4.ReadOnly = false;
        }

        private void Confirm_Edits_Button_Click(object sender, EventArgs e)
        {
            if (maskedTextBox13.Text.Length < 1 || maskedTextBox3.Text.Length < 1 || maskedTextBox4.Text.Length < 1 || maskedTextBox7.Text.Length < 11)
            {
                MessageBox.Show("Incomplete Information!");
                return;
            }
            else
            {
                MessageBox.Show("Location Updated");
                this.Hide();
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}