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
    public partial class Remove : Form
    {
        Controller controllerobj = new Controller();
        DataTable dt = null;
        DataTable dt1 = null;
        DataTable dt2 = null;
        DataTable dt3 = null;
        DataTable dt4 = null;
        DataTable dt5 = null;

        public Remove()
        {
            InitializeComponent();
            
            dt = controllerobj.filldepartements();
            dt1 = controllerobj.filldepartements();
            dt2 = controllerobj.filldepartements();
            
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Departement ID";
            
            comboBox5.DataSource = dt1;
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "Departement ID";
            
            comboBox7.DataSource = dt2;
            comboBox7.DisplayMember = "Name";
            comboBox7.ValueMember = "Departement ID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            h2.Show();
            this.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox5.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt4 = controllerobj.fillemployeebydept(value);
            if (dt4 != null)
            {
                comboBox6.DataSource = dt4;
                comboBox6.DisplayMember = "First name";
                comboBox6.ValueMember = "Employee ID";
                comboBox6.Refresh();
            }
            else
            {
                comboBox6.DataSource = dt4;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBox4.SelectedValue.ToString(), out value);
            controllerobj = new Controller();
            dt3 = controllerobj.fillemployeebydept(value);
            if (dt3!=null)
            {
                comboBox1.DataSource = dt3;
                comboBox1.DisplayMember = "First name";
                comboBox1.ValueMember = "Employee ID";
                comboBox1.Refresh();
            }
            else
            {
                comboBox1.DataSource = dt3;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt3 != null)
            {
                int value1;
                Int32.TryParse(comboBox1.SelectedValue.ToString(), out value1);
                maskedTextBox9.Text = value1.ToString();
            }
            else
            {
                maskedTextBox9.ResetText();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome newform = new welcome();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deleteuser = Convert.ToInt32(comboBox4.SelectedValue);           
            string deleteuser1 = maskedTextBox9.Text;
            controllerobj = new Controller();
            dt5 = controllerobj.retrievemanager(deleteuser.ToString());
            // needs more work to be running succesfully and change the above query
            if (dt5.ToString() == null)
            {
                int result = controllerobj.deleteemployee(deleteuser.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Deletion Occurs Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Can't Delete A Manager! Please Go To The Manager Section");
            }
        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt4 != null)
            {
                int value2;
                Int32.TryParse(comboBox6.SelectedValue.ToString(), out value2);
                maskedTextBox1.Text = value2.ToString();
            }
            else
            {
                maskedTextBox1.ResetText();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
