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
        DataTable dt = new DataTable();
        DataTable dtmaterialsused = new DataTable();
        public AddProduct(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
            dt = Controllerobj.Select_all_rawmaterials();
            MaterialsCombobox.DataSource = dt;
            MaterialsCombobox.DisplayMember = "Name";
            MaterialsCombobox.ValueMember = "Material ID";
            dtmaterialsused.Columns.Add("RawMaterialID", typeof(string));
            dtmaterialsused.Columns.Add("Raw Material Name", typeof(string));
            dataGridView1.ReadOnly = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fdistance;
            int idistance;
            if (ProductnametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Product name");
                return;
            }
            else if (DescriptiontextBox.Text == "")
            {
                MessageBox.Show("Please add a Product description");
                return;
            }
            else if (dtmaterialsused.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one material");
                return;
            }
            else if (!float.TryParse(PricetextBox.Text, out fdistance))
            {
                MessageBox.Show("Price can only be a number");
                return;
            }
            else if (!float.TryParse(ProductioncosttextBox.Text, out fdistance))
            {
                MessageBox.Show("Production cost can only be a number");
                return;
            }
            else if (!int.TryParse(AmountinstocktextBox.Text, out idistance))
            {
                MessageBox.Show("Amount in stock cost can only be a whole number");
                return;
            }
            else
            {


                string name = ProductnametextBox.Text;
                float price = float.Parse(PricetextBox.Text);
                int Amount_in_stock = int.Parse(AmountinstocktextBox.Text);
                string description = DescriptiontextBox.Text;
                int productioncost = int.Parse(ProductioncosttextBox.Text);
                int r = Controllerobj.Add_products(name, description, price, Amount_in_stock, productioncost);
                DataTable dataTable = Controllerobj.Select_product_By_name(name);
                string productID = dataTable.Rows[0][0].ToString();
                string rawmaterialsID;
                if (r > 0)
                {
                    int x;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        rawmaterialsID = dtmaterialsused.Rows[i][0].ToString();
                        x = Controllerobj.Insert_in_consumes(productID, rawmaterialsID);
                    }
                    MessageBox.Show("Product Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void Product_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertMaterialbutton_Click(object sender, EventArgs e)
        {
            if (MaterialsCombobox.SelectedIndex != -1)
            {
                dtmaterialsused.Rows.Add(MaterialsCombobox.SelectedValue.ToString(), MaterialsCombobox.Text);
                dataGridView1.DataSource = dtmaterialsused;
                dt.Rows.Remove(dt.Rows[MaterialsCombobox.SelectedIndex]);
                MaterialsCombobox.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Refresh();
            }
        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeHomepage f = new EmployeeHomepage(username,'p');
            f.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = Controllerobj.Select_all_rawmaterials();
            dataGridView1.ClearSelection();
            MaterialsCombobox.DataSource = dt;
            int x = dtmaterialsused.Rows.Count;
            for (int i = 0; i <x ; i++)
            {
                dtmaterialsused.Rows.Remove(dtmaterialsused.Rows[0]);
            }
            
            dataGridView1.Refresh();
        }
    }
}
