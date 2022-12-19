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
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome a = new welcome();
            this.Hide();
            a.Show();
        }

        private void ViewProfile_Button_Click(object sender, EventArgs e)
        {
            EditPD a = new EditPD();
            a.Show();
        }

        private void ViewProfile_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Complaint_Button_Click(object sender, EventArgs e)
        {
            ComplaintForm a = new ComplaintForm();
            a.Show();
        }

        private void OrderDetails_Button_Click(object sender, EventArgs e)
        {
            Customer_View_Orders a = new Customer_View_Orders();
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
            Customer_Catalogue a = new Customer_Catalogue();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
