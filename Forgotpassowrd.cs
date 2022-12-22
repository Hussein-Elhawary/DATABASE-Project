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
    public partial class Forgotpassowrd : Form
    {
        int trials = 0;
        Controller controllerobj = new Controller();
        public Forgotpassowrd()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make 2 different queries one for all employees and one for customer or one only and check inside to determine which select to use????
            
            DataTable dt = null;
            string un = maskedTextBox1.Text;
            string pn = maskedTextBox2.Text;
            string pass1 = textBox1.Text;
            string cpass = textBox2.Text;
            if (un == "" || pn == "")
            {
                MessageBox.Show("Please Enter Your Credentials!");
            }
            else
            {
                if (pass1 == "")
                {
                    MessageBox.Show("Please Enter Your New Passowrd!");
                }
                else
                {
                    if (cpass == "") 
                    {
                        MessageBox.Show("Please Enter The New Passowrd In The Confirm Field!");
                    }
                    else
                    {     
                        dt = controllerobj.forgotpasswordem1(un, pn);
                        if (dt == null)
                        {
                            MessageBox.Show("No Employee With This UserName OR Phone Number!" +"\n"+
                            "Please Contact The IT To Reset Your Data!");
                            trials++;
                        }
                        else
                        {
                            int result = controllerobj.changepasswordem(un, pn, pass1);
                            if (result == 1) 
                            {
                                MessageBox.Show("Your Password Has Been Updated");
                            }
                            else
                            {
                                MessageBox.Show("Your Password Can't Be Updated" + "\n" + "Please Try Again Later!");
                                trials++;
                            }
                        }                       
                    }
                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           // string pass1 = null;
           // Int32.TryParse(maskedTextBox4.Text, out pass1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string pass1 = null;
            pass1 = textBox1.Text;
            string pass2 = null;
            pass2 = textBox2.Text;
            if (pass2 != null && pass1 != null)
            {
                if (pass1 != pass2)
                {
                    label6.Text = "The 2 Password Don't Match!";
                }
                else
                {
                    label6.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Password!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
