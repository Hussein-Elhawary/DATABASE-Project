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
    public partial class ViewInsurance : Form
    {
        Controller controllerobj = new Controller();
        public ViewInsurance()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (radioButton1.Checked == true)
            {
                controllerobj = new Controller();
                dt = controllerobj.viewinsurance("H", "Giza");
                if (dt == null)
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
            else if (radioButton2.Checked == true)
            {
                controllerobj = new Controller();
                dt = controllerobj.viewinsurance("L", "Giza");
                if (dt == null)
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
            else if (radioButton3.Checked == true)
            {
                controllerobj = new Controller();
                dt = controllerobj.viewinsurance("P", "October");
                if (dt == null)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
