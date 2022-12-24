using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Project
{
    public partial class AddMaterial : Form
    {
        Controller Controllerobj = new Controller();
        string username;
        DataTable dt= new DataTable();
        public AddMaterial(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
            dt = Controllerobj.Select_all_Suppliers();
            SupplierCombobox.DataSource = dt;
            SupplierCombobox.DisplayMember = "Name";
            SupplierCombobox.ValueMember = "Supplier ID";
        }


        private void AddRawMaterialbutton_Click(object sender, EventArgs e)
        {
            float fdistance;
            int idistance;
            
            if (RawMaterialNametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Material name");
                return;
            }
            else if (PricetextBox.Text == "")
            {
                MessageBox.Show("Please Enter Material Price");
                return;
            }
            else if (WeightinstocktextBox.Text == "")
            {
                MessageBox.Show("Please Enter Material Weight in stock");
                return;
            }
            else if (SupplierCombobox.Text == "")
            {
                MessageBox.Show("Please Enter Material Supplier");
                return;
            }
            else if (DescriptiontextBox.Text == "")
            {
                MessageBox.Show("Please Enter Material Description");
                return;
            }
            else if (TypetextBox.Text == "")
            {
                MessageBox.Show("Please Enter Material Type");
                return;
            }
            else if (!float.TryParse(PricetextBox.Text, out fdistance))
            {
                MessageBox.Show("Price can only be a number");
                return;
            }
            else if (!int.TryParse(WeightinstocktextBox.Text, out idistance))
            {
                MessageBox.Show("Weight in stock can only be a number");
                return;
            }
            else
            {
                int r = Controllerobj.Add_Raw_material(RawMaterialNametextBox.Text, DescriptiontextBox.Text, float.Parse(PricetextBox.Text), int.Parse(WeightinstocktextBox.Text), SupplierCombobox.SelectedValue.ToString(), TypetextBox.Text);
                if (r > 0)
                {
                    MessageBox.Show("Material Added Successfully");
                }
                else
                {
                    MessageBox.Show("                                     Error Adding Materia " + Environment.NewLine+"Might be due to the name of the raw material already existing");
                }

            }


        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
