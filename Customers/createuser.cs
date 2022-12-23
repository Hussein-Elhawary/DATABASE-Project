using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Project
{
    public partial class createuser : Form
    {

        Controller ControllerDB;
        string DBFirstName, DBMiddleName, DBLastName, DBCOR, DBCity, DBAddress, DBEmail, DBCcode, DBphone, DB_BDate, DBGender, DBPreTime;
        public createuser(string FirstName,string MiddleName,string LastName,string COR,string City,string Address,string Email,string Ccode,string phone,string BDate,int Gender,string PreTime)
        {
            InitializeComponent();
            DBFirstName = FirstName;
            DBMiddleName = MiddleName;
            DBLastName = LastName;
            DBCOR = COR;
            DBCity = City;
            DBAddress = Address;
            DBEmail = Email;
            DBCcode = Ccode;
            DBphone = phone;
            DB_BDate = BDate;
            if (Gender == 0)
                DBGender = "M";
            else
                DBGender = "F";
            DBPreTime = PreTime + ":00";
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
            ControllerDB = new Controller();

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

            DataTable DT = ControllerDB.GetUsernamefromCustomerUsername(Username.Text);

            if (DT != null)
            {
                label4.Text = "Username Already Taken!";
                return;
            }

            label4.Text = "";

            ControllerDB = new Controller();
            DT = ControllerDB.SelectMaxCutomerID();

            int newID = Convert.ToInt16(DT.Rows[0][0]) + 1;

            string crypted_pass = Encrypt(Password.Text);

            ControllerDB.InsertNewCustomer(newID.ToString(),crypted_pass,Username.Text,DBFirstName,DBMiddleName,DBLastName,DBCOR,DBCity,DBAddress,DBEmail,DBCcode,DBphone,DB_BDate,DBGender,DBPreTime);

            welcome a = new welcome();
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
