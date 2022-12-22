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
            string comdate = null;
            string comdate1 = null;
            DateTime Today = DateTime.Today;
            if (radioButton1.Checked == true)//manager
            {
                if (radioButton6.Checked == true)
                {
                    comdate = Today.ToString("M/d/yyyy");
                    comdate1 = Today.ToString("M/d/yyyy");
                }
                else if (radioButton4.Checked == true)
                {
                    DateTime StartCM = new DateTime(Today.Year, Today.Month, 1);
                    DateTime ENDCM = new DateTime(Today.Year, Today.Month, 1).AddMonths(1).AddDays(-1);
                    comdate = StartCM.ToString("M/d/yyyy");
                    comdate1 = ENDCM.ToString("M/d/yyyy");
                }
                else if (radioButton3.Checked == true)
                {// I am not sure if the last month is december it will work or not
                    DateTime StartLM = new DateTime(Today.Year, Today.Month, 1).AddMonths(-1);
                    DateTime ENDLM = new DateTime(Today.Year, Today.Month, 1).AddDays(-1);
                    comdate = StartLM.ToString("M/d/yyyy");
                    comdate1 = ENDLM.ToString("M/d/yyyy");
                }
                else if (radioButton5.Checked == true)
                {
                    //all time,,, we may call its stored here
                }
                else
                {
                    MessageBox.Show("Please Choose The Complaint Time To Show Its Data!");
                }
                if (comdate != null)
                {
                    controllerobj = new Controller();
                    dt = controllerobj.viewmanagersrequests(comdate, comdate1);
                    dataGridView1.DataSource = dt;
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
            }///////////////////////////////////////////////////////////
            else if(radioButton2.Checked == true)//customer
            {
                if (radioButton6.Checked == true)
                {
                    comdate = Today.ToString("M/d/yyyy");
                    comdate1 = Today.ToString("M/d/yyyy");
                }
                else if (radioButton4.Checked == true)
                {
                    DateTime StartCM = new DateTime(Today.Year, Today.Month, 1);
                    DateTime ENDCM = new DateTime(Today.Year, Today.Month, 1).AddMonths(1).AddDays(-1);
                    comdate = StartCM.ToString("M/d/yyyy");
                    comdate1 = ENDCM.ToString("M/d/yyyy");
                }
                else if (radioButton3.Checked == true)
                {// I am not sure if the last month is december it will work or not
                    DateTime StartLM = new DateTime(Today.Year, Today.Month, 1).AddMonths(-1);
                    DateTime ENDLM = new DateTime(Today.Year, Today.Month, 1).AddDays(-1);
                    comdate = StartLM.ToString("M/d/yyyy");
                    comdate1 = ENDLM.ToString("M/d/yyyy");
                }
                else if (radioButton5.Checked == true)
                {
                    //all time,,, we may call its stored here
                }
                else
                {
                    MessageBox.Show("Please Choose The Complaint Time To Show Its Data!");
                }
                if (comdate != null)
                {
                    controllerobj = new Controller();
                    dt = controllerobj.viewcustomersrequests(comdate, comdate1);
                    dataGridView1.DataSource = dt;
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}


