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

        Controller ControllerDB;
        string Cust_ID;

        public EditPD()
        {
            InitializeComponent();
        }

        public EditPD(string id)
        {
            InitializeComponent();
            Cust_ID = id;
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

            ControllerDB = new Controller();
            DataTable DT = ControllerDB.GetCustomerINFO(Cust_ID);
            COD_textbox.Text = DT.Rows[0][6].ToString();
            maskedTextBox13.Text = DT.Rows[0][8].ToString();
            maskedTextBox3.Text = DT.Rows[0][7].ToString();
            maskedTextBox7.Text = DT.Rows[0][10].ToString();
            Ccode_textbox.Text = DT.Rows[0][11].ToString();
            maskedTextBox4.Text = DT.Rows[0][9].ToString();

            COD_textbox.ReadOnly = true;
            comboBox1.Enabled = false;
            Ccode_textbox.ReadOnly = true;
            maskedTextBox13.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            maskedTextBox7.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;
            chngPass_textbox.ReadOnly = true;
            ConfirmPassword_Button.Hide();

            Confirm_Edits_Button.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            COD_textbox.Hide();
            comboBox1.Enabled = true;
            maskedTextBox13.ReadOnly = false;
            maskedTextBox3.ReadOnly = false;
            Confirm_Edits_Button.Enabled = true;
            maskedTextBox7.ReadOnly = false;
            maskedTextBox4.ReadOnly = false;
            Ccode_textbox.ReadOnly = false;

        }

        private void Confirm_Edits_Button_Click(object sender, EventArgs e)
        {

            ControllerDB = new Controller();

            if (maskedTextBox13.Text.Length < 1 || maskedTextBox3.Text.Length < 1 || maskedTextBox4.Text.Length < 1 || maskedTextBox7.Text.Length < 11)
            {
                MessageBox.Show("Incomplete Information!");
                return;
            }
            else
            {
                ControllerDB.UpdateCustomerInfo(Cust_ID,comboBox1.Text,maskedTextBox13.Text,maskedTextBox3.Text,Ccode_textbox.Text,maskedTextBox7.Text,maskedTextBox4.Text);
                MessageBox.Show("Info Updated");
                this.Hide();
            }

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePass_textbox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chngPass_textbox.ReadOnly = false;
            ConfirmPassword_Button.Show();
        }

        private void ConfirmPassword_Button_Click(object sender, EventArgs e)
        {
            if (chngPass_textbox.Text.Length > 20 || chngPass_textbox.Text.Length < 8)
            {
                 MessageBox.Show("Password Must be between 8 and 20 characters!");
                return;
            }
            ControllerDB = new Controller();
            ControllerDB.UpdateCustomerPassword(Cust_ID,chngPass_textbox.Text);
            MessageBox.Show("Password Updated");
            this.Hide();
        }
    }
}