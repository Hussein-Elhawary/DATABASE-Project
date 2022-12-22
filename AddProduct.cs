using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class AddProduct : Form
    {
        string username;
        Controller Controllerobj = new Controller();
        public AddProduct(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = ProductnametextBox.Text;
            float price= float.Parse(PricetextBox.Text);
            int Amount_in_stock = int.Parse(AmountinstocktextBox.Text);
            string description = DescriptiontextBox.Text;
            int productioncost = int.Parse(ProductioncosttextBox.Text);
            int r = Controllerobj.Add_products(name, description, price, Amount_in_stock, productioncost);
            if (r > 0)
            {
                MessageBox.Show("Product Added Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
