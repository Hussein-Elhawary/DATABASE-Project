using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class EditPDE : Form
    { 
        string username;
        Controller controllerobj;
        DataTable dt = null;
        DataTable dt1 = null;
        public EditPDE(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
            UsernameTextbox.Text = username;
            controllerobj = new Controller();
            //call query to get the rest of the data
            //use the data to fill the rest of the textboxes
            dt = controllerobj.retrieveemployeebyusername(username);
            if (dt != null)
            {
                FirstnameTextbox.Text = dt.Rows[0]["First name"].ToString();
                MiddlenameTextbox.Text = dt.Rows[0]["Middle name"].ToString();
                LastnameTextbox.Text = dt.Rows[0]["Last name"].ToString();
                // EmailTextbox.Text = dt.Rows[0]["Email"].ToString();
                PhonenumberTextbox.Text = dt.Rows[0]["Phone"].ToString();
                DistrictTextbox.Text = dt.Rows[0]["District address"].ToString();
                CityTextbox.Text = dt.Rows[0]["City address"].ToString();
                CountryTextbox.Text = dt.Rows[0]["Country address"].ToString();
                GenderTextbox.Text = dt.Rows[0]["Gender"].ToString();
                SalaryTextbox.Text = dt.Rows[0]["Fixed Salary"].ToString();
                BirthDateTextbox.Text = dt.Rows[0]["Birth date"].ToString();
                NationalIDTextbox.Text = dt.Rows[0]["Employee ID"].ToString();
                NationalityTextbox.Text = dt.Rows[0]["Employee ID"].ToString();
                
            }
            dt1 = controllerobj.SelectDepartment(username);
            if (dt1 != null)
            {
                DepartmentTextbox.Text = dt1.Rows[0]["Department"].ToString();
            }
            
           // dt1 = controllerobj.sele(username);
            if (dt1 != null)
            {
                // DepartmentTextbox.Text = dt1.Rows[0]["Department"].ToString();
            }
        }

        private void EditPDE_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
    }

        //private void panel6_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
