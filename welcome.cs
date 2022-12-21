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
    public partial class welcome : Form
    {
        Controller controllerobj = new Controller();
        public welcome()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string un = maskedTextBox1.Text;
            string pass = maskedTextBox2.Text;
            if (un == "" || pass == "")
            {
                MessageBox.Show("Please Enter Your Credentials!");
            }
            else if (un[0] == 'I' || un[0] == 'i')
            {
                DataTable dt = null;
                controllerobj = new Controller();
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
            else if (un[0] == 'E' || un[0] == 'e')
            {
                DataTable dt = null;
                controllerobj = new Controller();
                dt = controllerobj.checke(un, pass);
                if (dt == null)
                {
                    MessageBox.Show("No Employee with this credentials");
                }
                else
                {
                    EmployeeHomepage h2 = new EmployeeHomepage(un);
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
