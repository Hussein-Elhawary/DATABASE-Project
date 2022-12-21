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
    public partial class ViewComplaints : Form
    {
        Controller controllerobj = new Controller();
        public ViewComplaints()
        {
            InitializeComponent();
            dataGridView1.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (radioButton1.Checked == true)
            {
                //dt = controllerobj.viewmanagersrequests();
                dataGridView1.DataSource = dt;
                if (dt == null)
                {
                    dataGridView1.Hide();
                    MessageBox.Show("No data is found");
                }
                else
                {
                    dataGridView1.Show();
                    if (radioButton6.Checked == true)
                    {

                    }
                    dataGridView1.DataSource = dt;
                }
            }
            else if(radioButton2.Checked == true)
            {
                dt = controllerobj.viewcustomersrequests();
                if (dt==null)
                {
                    dataGridView1.Hide();
                    MessageBox.Show("No data is found");
                }
                else
                {
                    dataGridView1.Show();
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a type of requests to show its data");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void ViewComplaints_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
