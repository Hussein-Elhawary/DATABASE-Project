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
    public partial class ViewBranchesAndRequests : Form
    {
        Controller controllerobj;
        Manager m;
        string username;
        DataTable dt;
        public ViewBranchesAndRequests()
        {
            InitializeComponent();
        }
        public ViewBranchesAndRequests(string us)
        {
            InitializeComponent();
            label1.Text = "Our Branches";
            username = us;
            m = new Manager(username);
            dt = new DataTable();
            controllerobj = new Controller();
            dt=controllerobj.fillbranch();
            if(dt!=null)
            dataGridView1.DataSource = dt;
            else
            {
                MessageBox.Show("There Are No Branches"); //impossible to happen but written for any validation needed here
                m.Show();
                this.Hide();
            }
        }
        public ViewBranchesAndRequests(string us, int x)
        {
            InitializeComponent();
            label1.Text = "My Requests";
            username = us;
            m = new Manager(username);
            dt = new DataTable();
            controllerobj = new Controller();
            dt = controllerobj.SelectManagerRequests(x);
            if (dt != null)
                dataGridView1.DataSource = dt;
            else
            {
                MessageBox.Show("There Are No Requests"); 
                m.Show();
                this.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Hide();
        }
    }
}
