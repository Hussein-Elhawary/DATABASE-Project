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
        string username;
        public ViewComplaints()
        {
            InitializeComponent();
            dataGridView1.Hide();
            button2.Hide();
            comboBox1.Hide();
        }

        public ViewComplaints(string user)
        {
            InitializeComponent();
            dataGridView1.Hide();
            username = user;
            button2.Hide();
            comboBox1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row;
            if (e.RowIndex >= 0)
            {
                row = dataGridView1.Rows[e.RowIndex];
                string text1 = row.Cells[1].Value.ToString();
                string text2 = row.Cells[0].Value.ToString();
                string text3 = row.Cells[2].Value.ToString();
                string text4 = row.Cells[3].Value.ToString();
                string text5 = row.Cells[5].Value.ToString();
                string text6 = row.Cells[6].Value.ToString();
                bool ma = radioButton1.Checked;
                bool em = radioButton2.Checked;
                if (ma == true)
                {
                    Requestdetails rq1 = new Requestdetails(text2, text1, text3, text4, text5, text6,1,username);
                    rq1.Show();
                }
                else if (em == true)
                {
                    Requestdetails rq1 = new Requestdetails(text2, text1, text3, text4, text5, text6, 2,username);
                    rq1.Show();
                }

                    
            }
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
                    controllerobj = new Controller();
                    dt = controllerobj.Select_ManagerRequests_UNResolved();
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
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Request ID";
                        comboBox1.ValueMember = "Request ID";
                    }
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
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Request ID";
                        comboBox1.ValueMember = "Request ID";
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
                    controllerobj = new Controller();
                    dt = controllerobj.Select_CustomerComplaints_UNResolved();
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
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Request ID";
                        comboBox1.ValueMember = "Request ID";
                    }
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
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Request ID";
                        comboBox1.ValueMember = "Request ID";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h1 = new Home(username);
            h1.Show();
            this.Hide();

        }
    }
}


