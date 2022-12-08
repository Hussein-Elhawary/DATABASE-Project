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
            welcom a = new welcom();
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
    }
}
