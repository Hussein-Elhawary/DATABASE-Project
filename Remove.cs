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
    public partial class Remove : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt1 = null;
        DataTable dt2 = null;
        DataTable dt3 = null;
        DataTable dt4 = null;
        DataTable dt5 = null;
        DataTable dt6 = null;
        DataTable dt7 = null;
        public Remove()
        {
            InitializeComponent();
            
            dt = controllerobj.filldepartements();
            dt1 = controllerobj.filldepartements();
            dt2 = controllerobj.filldepartements();
            
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
            
            comboBox5.DataSource = dt1;
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "Departement ID";
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            h2.Show();
            this.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox5.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt4 = controllerobj.fillemployeebydept(value);
            if (dt4 != null)
            {
                comboBox6.DataSource = dt4;
                comboBox6.DisplayMember = "First name";
                comboBox6.ValueMember = "Employee ID";
                comboBox6.Refresh();
            }
            else
            {
                comboBox6.DataSource = dt4;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox4.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt3 = controllerobj.fillemployeebydept(value);
            if (dt3!=null)
            {
                comboBox1.DataSource = dt3;
                comboBox1.DisplayMember = "First name";
                comboBox1.ValueMember = "Employee ID";
                comboBox1.Refresh();
            }
            else
            {
                comboBox1.DataSource = dt3;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt3 != null)
            {
                int value1;
                Int32.TryParse(comboBox1.SelectedValue.ToString(), out value1);
                maskedTextBox9.Text = value1.ToString();
                comboBox1.Refresh();
            }
            else
            {
                maskedTextBox9.ResetText();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {//delete occurs correctly but it should refresh the data in the combobox and textbox
            int depdel = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            string deleteuser1 = maskedTextBox9.Text;
            controllerobj = new Controller();
            dt5 = controllerobj.checkmanager(deleteuser1);
            if (dt5 == null)
            {
                controllerobj = new Controller();
                int result = controllerobj.deleteemployee(deleteuser1);
                if (result == 1)
                {
                    MessageBox.Show("Deletion Occurs Successfully");
                    controllerobj = new Controller();
                    dt6 = controllerobj.fillemployeebydept(depdel);
                    if (dt6 != null)
                    {
                        comboBox1.DataSource = dt6;
                        comboBox1.DisplayMember = "First name";
                        comboBox1.ValueMember = "Employee ID";
                        comboBox1.Refresh();
                        maskedTextBox9.ResetText();
                    }
                    else
                    {
                        comboBox1.DataSource = dt6;
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Can't Delete A Manager! Please Go To The Manager Section");
            }
        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt4 != null)
            {
                int value2;
                Int32.TryParse(comboBox6.SelectedValue.ToString(), out value2);
                maskedTextBox1.Text = value2.ToString();
            }
            else
            {
                maskedTextBox1.ResetText();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idd = maskedTextBox1.Text;
            string extension = maskedTextBox11.Text;
            if (idd == "" || idd == "0")
            {
                MessageBox.Show("Please Choose The Employee!");
            }
            else if (extension == "")
            {
                MessageBox.Show("Please Enter The New Extension");
            }
            else
            {
                
                controllerobj = new Controller();
                int see = controllerobj.updatextension(idd, extension);
                if (see == 1)
                {
                    MessageBox.Show("Update Is Done!");
                }
                else
                {
                    MessageBox.Show("Error Is Encountered!");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pass1 = null;
            pass1 = textBox1.Text;
            string pass2 = null;
            pass2 = maskedTextBox2.Text;
            string idd = maskedTextBox1.Text;            
            if (idd == "" || idd == "0")
            {
                MessageBox.Show("Please Choose The Employee!");
            }
            else if (pass2 == "")
            {
                MessageBox.Show("Please Enter The New Password!");
            }
            else
            {
                if (pass1 == "")
                {
                    MessageBox.Show("Please Enter The Confirmation Password!");
                }
                else
                {
                    controllerobj = new Controller();
                    string correctpass = Encrypt(pass1);
                    int seee = controllerobj.changepassbyit(correctpass, idd);
                    if (seee == 1)
                    {
                        MessageBox.Show("Update Is Done!");
                    }
                    else
                    {
                        MessageBox.Show("Error Is Encountered!");
                    }

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pass1 = null;
            pass1 = textBox1.Text;
            string pass2 = null;
            pass2 = maskedTextBox2.Text;
            if (pass2 != null && pass1 != null)
            {
                if (pass1 != pass2)
                {
                    label2.Text = "The 2 Password Don't Match!";
                }
                else
                {
                    label2.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Password!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pass1 = null;
            pass1 = textBox1.Text;
            string pass2 = null;
            pass2 = maskedTextBox2.Text;
            string idd = maskedTextBox1.Text;
            string extension = maskedTextBox11.Text;
           
            if (idd == "" || idd == "0")
            {
                MessageBox.Show("Please Choose The Employee!");
            }
            else if (extension == "")
            {
                MessageBox.Show("Please Enter The New Extension");
            }
            else if (pass2 == "")
            {
                MessageBox.Show("Please Enter The New Password!");
            }
            else
            {
                if (pass1 == "")
                {
                    MessageBox.Show("Please Enter The Confirmation Password!");
                }
                else
                {
                    controllerobj = new Controller();
                    string correctpass = Encrypt(pass1);
                    int seee = controllerobj.changepassbyit(correctpass, idd);
                    controllerobj = new Controller();
                    int see = controllerobj.updatextension(idd, extension);
                    if (seee == 1 && see == 1)
                    {
                        MessageBox.Show("Update Is Done!");
                    }
                    else
                    {
                        MessageBox.Show("Error Is Encountered!");
                    }

                }
            }

        }
    }
}
