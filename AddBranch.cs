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
    public partial class AddBranch : Form
    {
        Manager m;
        Controller controllerobj;
        DataTable dt;
        string username;
        public AddBranch()
        {
            InitializeComponent();
        }
        public AddBranch(string us)
        {
            InitializeComponent();
            username = us;
            controllerobj = new Controller();
            dt = new DataTable();
            dt = controllerobj.GetEmployeeIdFromUsername(us);
        }
        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //numbers only
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m = new Manager(username);
            this.Hide();
            m.Show();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
                e.Handled = true;
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

        private void maskedTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //numbers only
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == null || textBox2.Text == null || comboBox1.SelectedIndex < 0 || maskedTextBox7.Text == null || textBox4.Text == null || textBox5.Text == null || textBox6.Text == null)
                MessageBox.Show("There is some info missing");
            
            else if(maskedTextBox7.TextLength<11)
                MessageBox.Show("Telephone Number Not Correct");
            else
            {
               
                int r = 0;
               r= controllerobj.AddNewBranch(Convert.ToInt32(textBox3.Text), textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString(), textBox2.Text.ToString(), maskedTextBox7.Text.ToString(), comboBox1.Text.ToString(), Convert.ToInt32(dt.Rows[0][0]), dateTimePicker1.Text.ToString());
                if (r == 0)
                {
                    MessageBox.Show("Failed,This Branch No. already exist ");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
