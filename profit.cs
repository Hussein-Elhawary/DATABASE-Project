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
    public partial class profit : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt1 = null;
        public profit()
        {
            InitializeComponent();
            //dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comdate = null;
            string comdate1 = null;
            string comdate2 = null;
            string comdate3 = null;
            DateTime Today = DateTime.Today;
            if (radioButton4.Checked == true)   //this month
            {
                DateTime StartCM = new DateTime(Today.Year, Today.Month, 1);
                DateTime ENDCM = new DateTime(Today.Year, Today.Month, 1).AddMonths(1).AddDays(-1);
                comdate = StartCM.ToString("M/d/yyyy");
                comdate1 = ENDCM.ToString("M/d/yyyy");
                DateTime StartCMLY = new DateTime(Today.Year, Today.Month, 1).AddYears(-1);
                DateTime ENDCMLY = new DateTime(Today.Year, Today.Month, 1).AddYears(-1).AddMonths(1).AddDays(-1);
                comdate2 = StartCMLY.ToString("M/d/yyyy");
                comdate3 = ENDCMLY.ToString("M/d/yyyy");
                
                dt = controllerobj.getordersnew(comdate,comdate1);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Order Number";
                comboBox1.ValueMember = "Order Number";
                //dataGridView1.Show();
                //dataGridView1.DataSource = dt;
            }
            else if (radioButton3.Checked == true)//last month
            {
                DateTime StartLM = new DateTime(Today.Year, Today.Month, 1).AddMonths(-1);
                DateTime ENDLM = new DateTime(Today.Year, Today.Month, 1).AddDays(-1);
                comdate = StartLM.ToString("M/d/yyyy");
                comdate1 = ENDLM.ToString("M/d/yyyy");
            }
            else if (radioButton1.Checked == true)//this year
            {
                DateTime STARTY = new DateTime(Today.Year, 1, 1);
                DateTime ENDY = new DateTime(Today.Year, 12, 31);
                comdate = STARTY.ToString("M/d/yyyy");
                comdate1 = ENDY.ToString("M/d/yyyy");
            }
            else if (radioButton5.Checked == true)//all time
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
