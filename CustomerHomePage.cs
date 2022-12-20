using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{

    public partial class CustomerHomePage : Form
    {
        string Cus_ID;
        Controller ControllerDB;
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        public CustomerHomePage(string id)
        {
            InitializeComponent();
            Cus_ID = id;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome a = new welcome();
            this.Hide();
            a.Show();
        }

        private void ViewProfile_Button_Click(object sender, EventArgs e)
        {
            EditPD a = new EditPD(Cus_ID);
            a.Show();
        }

        private void ViewProfile_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Complaint_Button_Click(object sender, EventArgs e)
        {
            ComplaintForm a = new ComplaintForm(Cus_ID);
            a.Show();
        }

        private void OrderDetails_Button_Click(object sender, EventArgs e)
        {
            Customer_View_Orders a = new Customer_View_Orders(Cus_ID);
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductMenu_Button_Click(object sender, EventArgs e)
        {
            Customer_Catalogue a = new Customer_Catalogue(Cus_ID);
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            ControllerDB = new Controller();
            DataTable DT = ControllerDB.GetCustomerINFO(Cus_ID);
            UserLabel.Text = DT.Rows[0][3].ToString();
        }
    }
}
