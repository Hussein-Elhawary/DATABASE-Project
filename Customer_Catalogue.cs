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
    public partial class Customer_Catalogue : Form
    {

        Controller controllerobj;
        string Cust_ID;
        DataTable Shopping_Cart;
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

        }
    }
}
