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
        public Requestdetails()
        {
            InitializeComponent();
        }

        public Requestdetails(string id, string type, string date, string from, string on, string details,int ca)
        {
            InitializeComponent();
            if (ca == 1)//manager
            {
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
    }
}
