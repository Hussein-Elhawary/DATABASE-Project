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
        public ManagersupdatesbyIT()
        {
            InitializeComponent();
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
            dt = controllerobj.retrievemanager(value);
            dt1 = controllerobj.fillemployeebydept(value);
            if (dt != null) 
            {
                textBox1.Text = dt.Rows[0]["First name"].ToString();
                maskedTextBox9.Text = dt.Rows[0]["Employee ID"].ToString();
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "First name";
                comboBox1.ValueMember = "Employee ID";
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
            controllerobj = new Controller();
            string newname = comboBox1.SelectedValue.ToString();
            string deptid = comboBox4.SelectedValue.ToString();
            string startdate = DateTime.Today.ToString("M/d/yyyy");
            int result = controllerobj.updatemanager(newname,deptid,startdate);
            if (result == 1)
            {
                MessageBox.Show("Update Done!");
            }
            else
            {
                MessageBox.Show("Sad");
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
            int value1;
            Int32.TryParse(comboBox1.SelectedValue.ToString(), out value1);
            maskedTextBox5.Text = value1.ToString();
            
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
