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
    public partial class ManagersupdatesbyIT : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt1 = null;
        DataTable dt4 = null;
        public ManagersupdatesbyIT()
        {
            InitializeComponent();
            controllerobj = new Controller();
            dt = controllerobj.filldepartements();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox4.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt = controllerobj.retrievemanager(value.ToString());
            controllerobj = new Controller();
            dt1 = controllerobj.fillemployeebydept(value);
            if (dt != null) 
            {
                textBox1.Text = dt.Rows[0]["First name"].ToString();
                maskedTextBox9.Text = dt.Rows[0]["Employee ID"].ToString();
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "First name";
                comboBox1.ValueMember = "Employee ID";
                textBox3.Text = dt1.Rows[0]["Username"].ToString();
                textBox2.Text = dt.Rows[0]["Username"].ToString();
            }
            else
            {
                comboBox1.DataSource = dt1;
            }
        }

        private void ManagersupdatesbyIT_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resul1 = 0;
            int resul2 = 0;
            controllerobj = new Controller();
            string newname = comboBox1.SelectedValue.ToString();    // id of new manager
            string deptid = comboBox4.SelectedValue.ToString();     // id of the department
            string startdate = DateTime.Today.ToString("M/d/yyyy"); // start date
            if (newname != maskedTextBox9.Text)
            {
                int result = controllerobj.updatemanager(newname, deptid, startdate);
                
                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    controllerobj = new Controller();
                    resul1 = controllerobj.updateuserma(textBox3.Text,newname);
                    controllerobj = new Controller();
                    resul2 = controllerobj.updateuserem(textBox2.Text, maskedTextBox9.Text);
                }
                if (result == 1 && resul1 == 1 && resul2 == 1)
                {
                    MessageBox.Show("Update Done!");
                    dt = controllerobj.retrievemanager(deptid.ToString());
                    textBox1.Text = dt.Rows[0]["First name"].ToString();
                    textBox2.Text = dt.Rows[0]["Username"].ToString();
                    maskedTextBox9.Text = newname;
                    maskedTextBox1.ResetText();
                    textBox3.ResetText();
                }
                else
                {
                    MessageBox.Show("Sad");
                }
            }
            else
            {
                MessageBox.Show("The New Manager Can't Be The Same Current Manager");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt1 != null)
            {
                DataTable dt2 = null; 
                int value1;
                Int32.TryParse(comboBox1.SelectedValue.ToString(), out value1);
                maskedTextBox1.Text = value1.ToString();
                controllerobj = new Controller();
                dt2 = controllerobj.retrieveemployeebyid(value1);
                if (dt2 != null)
                {
                    textBox3.Text = dt2.Rows[0]["Username"].ToString();
                }
            }
            else
            {
                maskedTextBox1.ResetText();
                textBox3.ResetText();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
