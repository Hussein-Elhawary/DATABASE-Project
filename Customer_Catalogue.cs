using System;
using System.Collections;
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
    public partial class Customer_Catalogue : Form
    {

        Controller controllerobj;
        string Cust_ID;
        int RunningTotal = 0;
        DateTime ExpectedDate = DateTime.Now.AddDays(20);

        public Customer_Catalogue()
        {
            InitializeComponent();
        }
        
        public Customer_Catalogue(string id)
        {
            InitializeComponent();
            Cust_ID = id;
        }

        private void Return_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void Customer_Catalogue_Load(object sender, EventArgs e)
        {
            label8.Hide();
            controllerobj = new Controller();
            DataTable DT1 = controllerobj.SelectAllProdcuts();
            Product_List.DataSource = DT1;
            Product_List.ValueMember = "Product ID";
            Product_List.DisplayMember = "Name";

            controllerobj = new Controller();
            DataTable DT2 = controllerobj.SelectAllProdcutsForDatagrid();
            dataGridView1.DataSource = DT2;
            dataGridView1.Refresh();
        }

        private void AddToCart_Button_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "" || maskedTextBox1.Text == "0")
            {
                return;
            }
            
            if (Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(Product_List.SelectedIndex)].Cells["stock"].Value) < Convert.ToInt32(maskedTextBox1.Text))
            {
                MessageBox.Show("Not enough amount in stock!");
                return;
            }

            dataGridView1.Rows[Convert.ToInt32(Product_List.SelectedIndex)].Cells["stock"].Value = (Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(Product_List.SelectedIndex)].Cells["stock"].Value) - Convert.ToInt32(maskedTextBox1.Text)).ToString();

            controllerobj = new Controller();

            DataTable DT = controllerobj.SelectProdcutFromID(Product_List.SelectedValue.ToString());

            int TPrice = Convert.ToInt32(maskedTextBox1.Text) * Convert.ToInt32(DT.Rows[0][1].ToString());

            string[] row = new string[] { DT.Rows[0][3].ToString(), DT.Rows[0][1].ToString(),maskedTextBox1.Text,TPrice.ToString()};

            dataGridView2.Rows.Add(row);
            RunningTotal += TPrice;
            label6.Text = RunningTotal.ToString() + " $";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();

            if (dataGridView2.Rows.Count < 2)
            {
                MessageBox.Show("Order must contain atleast one item!");
                return;
            }

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                int StockTaken = Convert.ToInt32(dataGridView2.Rows[i].Cells["Column3"].Value);
                controllerobj.UpdateProductAfterMakingOrder(dataGridView2.Rows[i].Cells["Column1"].Value.ToString(),StockTaken);
            }

            DataTable DT = controllerobj.SelectMaxOrderNum();
            int next_ordernum = Convert.ToInt32(DT.Rows[0][0]) + 1;


            controllerobj.InsertNewOrder(next_ordernum.ToString(),Note_textbox.Text,DateTime.Now.ToString("yyyy-MM-dd"),"Pending",ExpectedDate.ToString("yyyy-MM-dd"),Cust_ID);

            MessageBox.Show("Order Made!");
            this.Hide();

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RunningTotal += 100;
                ExpectedDate = ExpectedDate.AddDays(-17);
                label8.Show();
                label6.Text = RunningTotal.ToString();
            }
            else if (checkBox1.Checked == false)
            {
                RunningTotal -= 100;
                ExpectedDate = ExpectedDate.AddDays(17);
                label8.Hide();
                label6.Text = RunningTotal.ToString();
            }
        }
    }
}
