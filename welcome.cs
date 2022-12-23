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
    public partial class welcome : Form
    {
        Controller controllerobj = new Controller();
        public welcome()
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustmerCA newform2 = new CustmerCA();
            this.Hide();
            newform2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassowrd h4 = new Forgotpassowrd();
            h4.Show();
            this.Hide();
        }
        //finance starts with f , Research p , General g
        private void button1_Click(object sender, EventArgs e)
        {
            string un = maskedTextBox1.Text;
            string Pass = maskedTextBox2.Text; 
            if (un == "" || Pass == "")
            {
                MessageBox.Show("Please Enter Your Credentials!");
            }
            else if (un[0] == 'I' || un[0] == 'i')//IT
            {
                
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    Home h1 = new Home(un);
                    h1.Show();
                    this.Hide();
                }
            }
            else if (un[0] == 'E' || un[0] == 'e')//general as well
            {
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    EmployeeHomepage h2 = new EmployeeHomepage(un,'g');
                    h2.Show();
                    this.Hide();
                }
            }
            else if (un[0] == 'G' || un[0] == 'g')//general
            {
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    EmployeeHomepage h2 = new EmployeeHomepage(un,'g');
                    h2.Show();
                    this.Hide();
                }
            }
            else if (un[0] == 'M' || un[0] == 'm')//Manager
            {
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, Pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    Manager h2 = new Manager(un);
                    h2.Show();
                    this.Hide();
                }
            }
            else if (un[0] == 'F' || un[0] == 'f')//finance
            {
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    EmployeeHomepage h2 = new EmployeeHomepage(un,'f');
                    h2.Show();
                    this.Hide();
                }
            }
            else if (un[0] == 'P' || un[0] == 'P')//Production
            {
                DataTable dt = null;
                controllerobj = new Controller();
                string pass = Encrypt(Pass);
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    EmployeeHomepage h2 = new EmployeeHomepage(un, 'p');
                    h2.Show();
                    this.Hide();
                }
            }

            else if (un[0] == 'C')
            {
                DataTable dt = null;
                controllerobj = new Controller();
                dt = controllerobj.GetUsernamefromCustomerUsername(un);
                if (dt == null)
                {
                    MessageBox.Show("No Customer with this credentials!");
                    return;
                }
                else
                {
                    controllerobj = new Controller();
                    dt = controllerobj.SelectCPassFromCUsername(un);
                    string pass = Encrypt(Pass);
                    if (pass == dt.Rows[0][0].ToString())
                    {
                        controllerobj = new Controller();
                        dt = controllerobj.GetCustIDfromCustUn(un);
                        CustomerHomePage a = new CustomerHomePage(dt.Rows[0][0].ToString());
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                        return;
                    }
                }
            }
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
