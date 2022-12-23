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
    public partial class ViewEmployees : Form
    {
        DataTable dt;
        Controller controllerobj;
        Manager m;
        string username;
        public ViewEmployees()
        {
            
            InitializeComponent();
           
        }
        public ViewEmployees(string fname,string mname,string lname,string us)
        {
            username = us;
            InitializeComponent();
            m = new Manager(username);
            controllerobj = new Controller();
            dt = new DataTable();
            dt = controllerobj.SelectEmployeesbyName(fname, mname, lname);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Close();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
