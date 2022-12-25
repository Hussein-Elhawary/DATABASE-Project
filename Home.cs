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
        string username;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeCA eca = new EmployeeCA(username);
            eca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewComplaints vca = new ViewComplaints(username);
            vca.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditPDE pd = new EditPDE(username);
            pd.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w1 = new welcome();
            w1.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewInsurance vi = new ViewInsurance(username);
            vi.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Remove ri = new Remove(username);
            ri.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagersupdatesbyIT mi = new ManagersupdatesbyIT(username);
            mi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewprojectE v1 = new ViewprojectE(username);
            v1.Show();
            this.Hide();
        }
    }
}
