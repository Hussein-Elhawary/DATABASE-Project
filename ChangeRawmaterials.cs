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
    public partial class ChangeRawmaterials : Form
    {
        string username;
        DataTable dt;
        DataTable dt1;
        Controller ControllerObj = new Controller();
        public ChangeRawmaterials(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
            dt = ControllerObj.Select_All_raw_materials_and_their_suppliers();
            dt.Columns["Name1"].ColumnName = "Supplier Name";
            Raw_materils_List.DataSource = dt;
            Raw_materils_List.DisplayMember = "Name";
            Raw_materils_List.ValueMember = "Material ID";
            Raw_materils_List.Refresh();
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Viewdatabutton_Click(object sender, EventArgs e)
        {

            Discriptiontextbox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Description"].ToString();
            PricetextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Price"].ToString();
            WeightinstocktextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["weight in stock"].ToString();
            TypetextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Type"].ToString();
            SuppliertextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Supplier Name"].ToString();
        }

        private void updatedatabutton_Click(object sender, EventArgs e)
        {
            int idistance;
            float fdistance;
            if (!(float.TryParse(PricetextBox.Text, out fdistance)))
            {
                MessageBox.Show("Product Price must be a number");
                return;
            }
            else if (!(int.TryParse(WeightinstocktextBox.Text, out idistance)))
            {
                MessageBox.Show("weight must be an integer");
                return;
            }

            string name = Raw_materils_List.Text;
            string description = Discriptiontextbox.Text;
            float price = float.Parse(PricetextBox.Text);
            string weight = WeightinstocktextBox.Text;
            string type = TypetextBox.Text;
            string ID = Raw_materils_List.SelectedValue.ToString();
            if (name=="")
            {
                MessageBox.Show("Please enter Raw material name");
                return;
            }
            if (description == "")
            {
                MessageBox.Show("Please enter Raw material description");
                return;
            }
            if (price == 0)
            {
                MessageBox.Show("Please enter Raw material price");
                return;
            }
            if (weight == "")
            {
                MessageBox.Show("Please enter Raw material weight");
                return;
            }
            if (type == "")
            {
                MessageBox.Show("Please enter Raw material type");
                return;
            }
            
            int r = ControllerObj.Update_Raw_materials(ID, name, description, price, weight, type);
            if (r > 0)
            {
                MessageBox.Show("Raw material updated successfully");
                dt = ControllerObj.Select_All_raw_materials_and_their_suppliers();
                Raw_materils_List.DataSource = dt;
                Raw_materils_List.DisplayMember = "Name";
                Raw_materils_List.ValueMember = "Material ID";
                Raw_materils_List.Refresh();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Raw material update failed");
            }
        }

        private void DeleteRawMaterialbutton_Click(object sender, EventArgs e)
        {
            string ID = Raw_materils_List.SelectedValue.ToString();
            int r = ControllerObj.Delete_Rawmaterial(ID);
            if (r > 0)
            {
                MessageBox.Show("Raw material deleted successfully");
                dt = ControllerObj.Select_All_raw_materials_and_their_suppliers();
                Raw_materils_List.DataSource = dt;
                Raw_materils_List.DisplayMember = "R.Name";
                Raw_materils_List.ValueMember = "Material ID";
                Raw_materils_List.Refresh();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Raw material delete failed");
            }
        }

        private void AddRawMaterialbutton_Click(object sender, EventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial(username);
            addMaterial.Show();
        }

        private void Reffreshdata_Click(object sender, EventArgs e)
        {
            dt = ControllerObj.Select_All_raw_materials_and_their_suppliers();
            if (dt==null)
            {
                MessageBox.Show("No Raw Materials to Show");
                return;
            }
            dt.Columns["Name1"].ColumnName = "Supplier Name";
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            Raw_materils_List.DataSource = dt;
            Raw_materils_List.DisplayMember = "R.Name";
            Raw_materils_List.ValueMember = "Material ID";
            Raw_materils_List.Refresh();

            Discriptiontextbox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Description"].ToString();
            PricetextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Price"].ToString();
            WeightinstocktextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["weight in stock"].ToString();
            TypetextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Type"].ToString();
            SuppliertextBox.Text = dt.Rows[Raw_materils_List.SelectedIndex]["Supplier Name"].ToString();
        }

        private void SuppliertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
