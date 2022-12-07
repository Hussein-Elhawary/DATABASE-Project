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
    public partial class createuser : Form
    {
        public createuser(string FirstName,string MiddleName,string LastName,string COR,string City,string Address,string Email,string phone,string BDate,int Gender,string PreTime)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustmerCA a = new CustmerCA();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Username.Text[0] != 'C')
            {
                label4.Text = "UserName Must start with an UpperCase C !";
                return;
            }

            if (Username.Text.Length > 15 || Username.Text.Length < 5)
            {
                label4.Text = "UserName Must be between 5 and 15 characters!";
                return;
            }

            if (Password.Text.Length > 20 || Password.Text.Length < 8)
            {
                label4.Text = "Password Must be between 8 and 20 characters!";
                return;
            }

            if (Password.Text != PasswordAgain.Text)
            {
                label4.Text = "Passwords are not matching!";
                return;
            }
            label4.Text = "";

            CustomerHomePage a = new CustomerHomePage();
            this.Hide();
            a.Show();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
                PasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                PasswordAgain.UseSystemPasswordChar = true;
            }
        }

        private void createuser_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
            PasswordAgain.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
