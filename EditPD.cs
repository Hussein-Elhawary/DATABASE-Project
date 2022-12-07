using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EditPD : Form
    {
        public EditPD()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            CustomerHomePage a = new CustomerHomePage();
            this.Hide();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
