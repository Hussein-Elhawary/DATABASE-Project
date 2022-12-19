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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeCA eca = new EmployeeCA();
            eca.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewComplaints vca = new ViewComplaints();
            vca.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personal_Data pd = new Personal_Data();
            pd.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w1 = new welcome();
            w1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
