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
    public partial class Checkpasswordandupdate : Form
    {
        Controller Controllerobj = new Controller();
        string username;
        string password;
        DataTable updater;
        string type;
        public Checkpasswordandupdate(string user, string pass,DataTable updaterc,string typec)//type either pass or other
        {
            InitializeComponent();
            username = user;
            password = pass;
            updater = updaterc;
            label2.Hide();
            type = typec;
            label3.Visible = false;
            label1.Visible = false;
            if (type=="pass")
            {
                label3.Visible = true;
            }
            else
            {
                label1.Visible = true;
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Confirm_Click_1(object sender, EventArgs e)
        {
            string encryptedpass = Encrypt(textBox1.Text);
            if (encryptedpass == password)
            {
                if (type == "pass")
                {
                    Forgotpassowrd forgotpassowrd = new Forgotpassowrd();
                    forgotpassowrd.Show();
                    this.Hide();
                }
                else
                {

                    string Country = (updater.Rows[0]["Country address"]).ToString();
                    string City = (updater.Rows[0]["City address"]).ToString();
                    string District = (updater.Rows[0]["District address"]).ToString();
                    string Phone = (updater.Rows[0]["Phone"]).ToString();
                    int r = Controllerobj.UpdateEmployeeInfo(username, Country, City, District, Phone);
                    if (r > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
            }
            else
            {
                label2.Show();
            }
        }

        private void Checkpasswordandupdate_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
