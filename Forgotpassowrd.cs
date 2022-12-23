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
    public partial class Forgotpassowrd : Form
    {
        int trials = 0;
        Controller controllerobj = new Controller();
        public Forgotpassowrd()
        {
            InitializeComponent();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                        string pass = Encrypt(cpass);
                        if (un[0] == 'c' || un[0] == 'C')
                        {
                            controllerobj = new Controller();
                            dt = controllerobj.forgotpassword(un, pn, 'C');
                            if (dt == null)
                            {
                                MessageBox.Show("No Customer With This UserName OR Phone Number!");
                                trials++;
                            }
                            else
                            {
                                controllerobj = new Controller();
                                int result = controllerobj.changepasswordem(un, pn, pass, 'C');
                                if (result == 1)
                                {
                                    MessageBox.Show("Your Password Has Been Updated");
                                    this.Hide();
                                    welcome w1 = new welcome();
                                    w1.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Your Password Can't Be Updated" + "\n" + "Please Try Again Later!");
                                    trials++;
                                }
                            }
                        }
                        else
                        {
                            controllerobj = new Controller();
                            dt = controllerobj.forgotpassword(un, pn, 'E');
                            if (dt == null)
                            {
                                MessageBox.Show("No Employee With This UserName OR Phone Number!");
                                trials++;
                            }
                            else
                            {
                                controllerobj = new Controller();
                                int result = controllerobj.changepasswordem(un, pn, pass, 'E');
                                if (result == 1)
                                {
                                    MessageBox.Show("Your Password Has Been Updated");
                                    this.Hide();
                                    welcome w1 = new welcome();
                                    w1.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Your Password Can't Be Updated" + "\n" + "Please Try Again Later!");
                                    trials++;
                                }
                            }
                        }
                        if (trials == 3) 
                        {
                            MessageBox.Show("Your Trails To Update The Password Has Finished" + "\n" + 
                                "Please Contact The IT To Help You");
                            this.Close();
                            // mmkn n3ml direct 3l2 form el requests 
                        }
                    }
                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

