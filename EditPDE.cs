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
                comboBox1.SelectedItem = dt.Rows[0]["Country address"].ToString();
                if ((dt.Rows[0]["Gender"]).ToString() == "True")
                {
                    GenderTextbox.Text = "Male";
                }
                else
                {
                    GenderTextbox.Text = "Female";
                }
                SalaryTextbox.Text = dt.Rows[0]["Fixed Salary"].ToString();
                BirthDateTextbox.Text = dt.Rows[0]["Birth date"].ToString();
                NationalIDTextbox.Text = dt.Rows[0]["Employee ID"].ToString();
                NationalityTextbox.Text = dt.Rows[0]["Employee ID"].ToString();
                ExtentionTextbox.Text = dt.Rows[0]["Extension"].ToString();
            }
            dt1 = controllerobj.SelectDepartmentByID(dt.Rows[0]["Department"].ToString());
            if (dt1 != null)
            {
                DepartmentTextbox.Text = dt1.Rows[0]["Name"].ToString();
            }

            dt1 = controllerobj.SelectBranchByID(dt.Rows[0]["Branch"].ToString());
            if (dt1 != null)
            {
                BranchTextbox.Text = dt1.Rows[0]["Type"].ToString();//type because branches dont have names
            }
        }

        private void EditPDE_Load(object sender, EventArgs e)
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

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExtentionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateInformation_Click_1(object sender, EventArgs e)
        {
            if ((PhonenumberTextbox.Text).Length!=11)
            {
                MessageBox.Show("Phone number should be 11 digits");
                return;
            }
            else if (DistrictTextbox.Text=="")
            {
                MessageBox.Show("Please add district");
                return;
            }
            else if (CityTextbox.Text == "")
            {
                MessageBox.Show("Please add City");
                return;
            }


            dt.Rows[0]["Phone"] = PhonenumberTextbox.Text;
            dt.Rows[0]["District address"] = DistrictTextbox.Text;
            dt.Rows[0]["City address"] = CityTextbox.Text;
            dt.Rows[0]["Country address"] = comboBox1.SelectedItem.ToString();
            Checkpasswordandupdate checkpasswordandupdateobj = new Checkpasswordandupdate(username, dt.Rows[0]["Password"].ToString(), dt,"other");
            checkpasswordandupdateobj.Show();
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }


        private void PhonenumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Checkpasswordandupdate checkpasswordandupdateobj = new Checkpasswordandupdate(username, dt.Rows[0]["Password"].ToString(), dt, "pass");
            checkpasswordandupdateobj.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string str= username.Substring(0, 1);
            if (str == "m" || str == "M")
            {
                Manager m1 = new Manager(username);
                m1.Show();
                this.Hide();
            }
            else if (str == "i" || str == "I")
            {
                Home h1 = new Home(username);
                h1.Show();
                this.Hide();
            }
            else if (str == "e" || str == "E")
            {
                EmployeeHomepage h2 = new EmployeeHomepage(username, 'g');
                h2.Show();
                this.Hide();
            }
            else if (str == "g" || str == "G")
            {
                EmployeeHomepage h2 = new EmployeeHomepage(username, 'g');
                h2.Show();
                this.Hide();
            }
            else if (str == "f" || str == "F") //finance
            {
                EmployeeHomepage h2 = new EmployeeHomepage(username, 'f');
                h2.Show();
                this.Hide();
            }
            else if (str == "p" || str == "P") //production
            {
                EmployeeHomepage h2 = new EmployeeHomepage(username, 'p');
                h2.Show();
                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void PhonenumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //letters only
            {
                e.Handled = true;
                MessageBox.Show("You can only enter letters!");
                return;
            }
        }

        private void DistrictTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

}
