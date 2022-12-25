using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comdate1s = null;
            string comdate1e = null;
            string comdate2s = null;
            string comdate2e = null;

            DateTime ENDCM = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1);
            comdate1e = ENDCM.ToString("M/d/yyyy");
            DateTime StartCM = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            comdate1s = StartCM.ToString("M/d/yyyy");


            DateTime ENDCM2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1).AddMonths(1).AddDays(-1);
            comdate2e = ENDCM2.ToString("M/d/yyyy");
            DateTime StartCM2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1);
            comdate2s = StartCM2.ToString("M/d/yyyy");
            controllerobj = new Controller();
            dt = controllerobj.getordersnew(comdate1s, comdate1e);
            controllerobj = new Controller();
            dt1 = controllerobj.getordersnew(comdate2s, comdate2e);
            if (dt == null)
            {
                MessageBox.Show("The first month has no orders");
                return;
            }
            if (dt1 == null)
            {
                MessageBox.Show("The second month has no orders");
                return;
            }
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt1;

                dt.Columns.Add("Profit", typeof(float));
                dt1.Columns.Add("Profit", typeof(float));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string x = (dt.Rows[i]["Total selling price"]).ToString();
                    float xf = float.Parse(x);
                    string y = (dt.Rows[i]["Total cost"]).ToString();
                    float yf = float.Parse(y);
                    dt.Rows[i]["Profit"] = xf - yf;
                    string x1 = (dt1.Rows[i]["Total selling price"]).ToString();
                    float xf1 = float.Parse(x1);
                    string y1 = (dt1.Rows[i]["Total cost"]).ToString();
                    float yf1 = float.Parse(y1);
                    dt1.Rows[i]["Profit"] = xf - yf;
                }
                dataGridView1.Columns["Customer ID"].Visible = false;
                dataGridView2.Columns["Customer ID"].Visible = false;
                //    if (radioButton4.Checked == true)   //this month
                //    {
                //        
                //        DateTime StartCMLY = new DateTime(Today.Year, Today.Month, 1).AddYears(-1);
                //        DateTime ENDCMLY = new DateTime(Today.Year, Today.Month, 1).AddYears(-1).AddMonths(1).AddDays(-1);
                //        comdate2 = StartCMLY.ToString("M/d/yyyy");
                //        comdate3 = ENDCMLY.ToString("M/d/yyyy");

                //        dt = controllerobj.getordersnew(comdate,comdate1);
                //        dt1 = controllerobj.getordersnew(comdate2,comdate3);
                //        comboBox1.DataSource = dt;
                //        comboBox1.DisplayMember = "Order Number";
                //        comboBox1.ValueMember = "Order Number";
                //        //dataGridView1.Show();
                //        //dataGridView1.DataSource = dt;
                //    }
                //    else if (radioButton3.Checked == true)//last month
                //    {
                //        DateTime StartLM = new DateTime(Today.Year, Today.Month, 1).AddMonths(-1);
                //        DateTime ENDLM = new DateTime(Today.Year, Today.Month, 1).AddDays(-1);
                //        comdate = StartLM.ToString("M/d/yyyy");
                //        comdate1 = ENDLM.ToString("M/d/yyyy");
                //    }
                //    else if (radioButton1.Checked == true)//this year
                //    {
                //        DateTime STARTY = new DateTime(Today.Year, 1, 1);
                //        DateTime ENDY = new DateTime(Today.Year, 12, 31);
                //        comdate = STARTY.ToString("M/d/yyyy");
                //        comdate1 = ENDY.ToString("M/d/yyyy");
                //    }
                //    else if (radioButton5.Checked == true)//all time
                //    {

                //    }

            
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome w2 = new welcome();
            w2.Show();
            this.Close();
        }
    }
}
