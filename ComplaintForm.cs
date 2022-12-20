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
    public partial class ComplaintForm : Form
    {

        Controller controllerobj;
        string Cust_ID;

        public ComplaintForm()
        {
            InitializeComponent();
        }

        public ComplaintForm(string id)
        {
            InitializeComponent();
            Cust_ID = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            string aa = comboBox2.Text.ToString();
            if (aa == "Yes")
            {
                maskedTextBox1.AppendText("Thanks");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "")
            {
                label8.Text = "Please fill the Detail box!";
                label8.Show();
                return;
            }

            controllerobj = new Controller();
            DataTable DT = controllerobj.SelectMaxCustRequetID();
            string next_ID = (Convert.ToInt16(DT.Rows[0][0]) + 1).ToString();
   
            controllerobj.InsertNewCustRequest(next_ID,comboBox1.Text,DateTime.Now.ToString("yyyy-MM-dd"),richTextBox1.Text,"No","1",Cust_ID,comboBox3.Text);
            MessageBox.Show("Request Sent");
            this.Hide();

        }

        private void ComplaintForm_Load(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            DataTable DT = controllerobj.GetOdersforSelectedCustomer(Cust_ID);
            comboBox3.DataSource = DT;
            comboBox3.ValueMember = "Order Number";
            comboBox3.DisplayMember = "Order Number";
            label8.Hide();
        }
    }
}
