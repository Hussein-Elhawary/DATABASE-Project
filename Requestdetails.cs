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
    public partial class Requestdetails : Form
    {
        int RT = 0;
        string username = null;
        DataTable dt = null;
        Controller controllerobj = new Controller();
        public Requestdetails()
        {
            InitializeComponent();
        }

        public Requestdetails(string id, string type, string date, string from, string on, string details,int ca,string user)
        {
            InitializeComponent();
            if (ca == 1)//manager
            {
                controllerobj = new Controller();
                dt = controllerobj.retrievePD(user);
                username = dt.Rows[0]["Employee ID"].ToString();
                RT = 1;
                textBox5.Hide();
                label5.Hide();
                textBox1.Text = id;
                textBox2.Text = type;
                textBox3.Text = date;
                textBox4.Text = details;
                textBox6.Text = from;
            }
            else if (ca == 2)
            {
                RT = 2;
                controllerobj = new Controller();
                dt = controllerobj.retrievePD(user);
                username = dt.Rows[0]["Employee ID"].ToString();
                textBox1.Text = id;
                textBox2.Text = type;
                textBox3.Text = date;
                textBox4.Text = details;
                textBox5.Text = on;
                textBox6.Text = from;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Requestdetails_Load(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string id = textBox1.Text;
                controllerobj = new Controller();
                int result = controllerobj.closetherequest(id, RT, username);
                if (result == 1)
                {
                    MessageBox.Show("Thanks For Your Effort!");
                }
                else
                {
                    MessageBox.Show("Please Try Again Later! Server Error");
                }
            }
            else
            {
                MessageBox.Show("Resolve The Request First!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w2 = new welcome();
            w2.Show();
            this.Close();
        }
    }
}
