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
        DataTable dt2;
        Controller controllerobj;
        Manager m;
        string username;
        public ViewEmployees()
        {
            
            InitializeComponent();
           
        }
        public ViewEmployees(string us,int projectid)
        {
            InitializeComponent();
            username = us;
            m = new Manager(username);
            controllerobj = new Controller();
            dt = new DataTable();
            dt = controllerobj.SelectDepartment(username); //to get department of manager in order to show employees from his department working on the project
            controllerobj = new Controller();
            dt2 = controllerobj.SelectEmployeesWorkOnProject(Convert.ToInt32(dt.Rows[0][0]),projectid);
            if(dt2==null)
            {
                MessageBox.Show("There Are No Employees From Your Department Working On That Project");
                m.Show();
                this.Close();
            }
            else
            dataGridView1.DataSource = dt2;
        }
        public ViewEmployees(string fname,string mname,string lname,string us)
        {
            InitializeComponent();
            username = us;
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
