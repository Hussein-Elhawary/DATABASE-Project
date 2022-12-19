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
        public ManagersupdatesbyIT()
        {
            InitializeComponent();
            dt = controllerobj.filldepartements();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
            //comboBox4.Text = "Select Departement";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//not working
            string deptid = comboBox4.SelectedValue.ToString();
            dt = controllerobj.retrievemanager(deptid);
            textBox1.Text = dt.Columns[9].ToString();
        }
    }
}
