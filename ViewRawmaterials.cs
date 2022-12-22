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
    public partial class ViewRawmaterials : Form
    {
        string username;
        public ViewRawmaterials(string usernamec)
        {
            InitializeComponent();
            username = usernamec;
        }
    }
}
