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
    public partial class Remove : Form
    {
        Controller controllerobj = new Controller();
        public Remove()
        {
            InitializeComponent();
            DataTable dt = null;
            DataTable dt1 = null;
            DataTable dt2 = null;
            
            dt = controllerobj.filldepartements();
            dt1 = controllerobj.filldepartements();
            dt2 = controllerobj.filldepartements();
            
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
            
            comboBox5.DataSource = dt1;
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "Departement ID";
            
            comboBox7.DataSource = dt2;
            comboBox7.DisplayMember = "Name";
            comboBox7.ValueMember = "Departement ID";
            
            dt1 = controllerobj.fillemployeesnames();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "First Name";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            h2.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Remove_Load(object sender, EventArgs e)
        {

        }
    }
}
