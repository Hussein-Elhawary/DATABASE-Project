namespace Project
{
    partial class EditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Reffreshdata = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.deleteProductbutton = new System.Windows.Forms.Button();
            this.updatedata = new System.Windows.Forms.Button();
            this.Viewdatabutton = new System.Windows.Forms.Button();
            this.poduction = new System.Windows.Forms.Label();
            this.ProductionCosttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountinstocktextBox = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Product_List = new System.Windows.Forms.ComboBox();
            this.disc = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Discriptiontextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 46);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1151, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 29);
            this.linkLabel1.TabIndex = 220;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Project.Properties.Resources.imgbin_computer_icons_home_button_sign_home_MkjkgcTaBkXHYRzyyEgLbmQ2m;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(3, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 42);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(515, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 613);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 661);
            this.panel2.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.Reffreshdata);
            this.panel6.Controls.Add(this.AddProduct);
            this.panel6.Controls.Add(this.deleteProductbutton);
            this.panel6.Controls.Add(this.updatedata);
            this.panel6.Controls.Add(this.Viewdatabutton);
            this.panel6.Controls.Add(this.poduction);
            this.panel6.Controls.Add(this.ProductionCosttextBox);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.AmountinstocktextBox);
            this.panel6.Controls.Add(this.Price);
            this.panel6.Controls.Add(this.PricetextBox);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.Product_List);
            this.panel6.Controls.Add(this.disc);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.Discriptiontextbox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(774, 565);
            this.panel6.TabIndex = 32;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // Reffreshdata
            // 
            this.Reffreshdata.Location = new System.Drawing.Point(3, 54);
            this.Reffreshdata.Name = "Reffreshdata";
            this.Reffreshdata.Size = new System.Drawing.Size(80, 43);
            this.Reffreshdata.TabIndex = 26;
            this.Reffreshdata.Text = "Refresh\r\nData";
            this.Reffreshdata.UseVisualStyleBackColor = true;
            this.Reffreshdata.Click += new System.EventHandler(this.Reffreshdata_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(632, 160);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(130, 39);
            this.AddProduct.TabIndex = 25;
            this.AddProduct.Text = "Add new product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // deleteProductbutton
            // 
            this.deleteProductbutton.Location = new System.Drawing.Point(12, 160);
            this.deleteProductbutton.Name = "deleteProductbutton";
            this.deleteProductbutton.Size = new System.Drawing.Size(116, 39);
            this.deleteProductbutton.TabIndex = 24;
            this.deleteProductbutton.Text = "Delete Product";
            this.deleteProductbutton.UseVisualStyleBackColor = true;
            this.deleteProductbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatedata
            // 
            this.updatedata.Location = new System.Drawing.Point(320, 160);
            this.updatedata.Name = "updatedata";
            this.updatedata.Size = new System.Drawing.Size(116, 39);
            this.updatedata.TabIndex = 23;
            this.updatedata.Text = "updatedata";
            this.updatedata.UseVisualStyleBackColor = true;
            this.updatedata.Click += new System.EventHandler(this.updatedata_Click);
            // 
            // Viewdatabutton
            // 
            this.Viewdatabutton.Location = new System.Drawing.Point(646, 56);
            this.Viewdatabutton.Name = "Viewdatabutton";
            this.Viewdatabutton.Size = new System.Drawing.Size(116, 39);
            this.Viewdatabutton.TabIndex = 22;
            this.Viewdatabutton.Text = "ViewData";
            this.Viewdatabutton.UseVisualStyleBackColor = true;
            this.Viewdatabutton.Click += new System.EventHandler(this.Viewdatabutton_Click);
            // 
            // poduction
            // 
            this.poduction.AutoSize = true;
            this.poduction.Location = new System.Drawing.Point(573, 104);
            this.poduction.Name = "poduction";
            this.poduction.Size = new System.Drawing.Size(106, 17);
            this.poduction.TabIndex = 21;
            this.poduction.Text = "Production cost";
            // 
            // ProductionCosttextBox
            // 
            this.ProductionCosttextBox.Location = new System.Drawing.Point(576, 123);
            this.ProductionCosttextBox.Name = "ProductionCosttextBox";
            this.ProductionCosttextBox.Size = new System.Drawing.Size(150, 22);
            this.ProductionCosttextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount in stock";
            // 
            // AmountinstocktextBox
            // 
            this.AmountinstocktextBox.Location = new System.Drawing.Point(394, 123);
            this.AmountinstocktextBox.Name = "AmountinstocktextBox";
            this.AmountinstocktextBox.Size = new System.Drawing.Size(150, 22);
            this.AmountinstocktextBox.TabIndex = 18;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(220, 104);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 17;
            this.Price.Text = "Price";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(223, 123);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(150, 22);
            this.PricetextBox.TabIndex = 16;
            this.PricetextBox.TextChanged += new System.EventHandler(this.PricetextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 318);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product List";
            // 
            // Product_List
            // 
            this.Product_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_List.FormattingEnabled = true;
            this.Product_List.Location = new System.Drawing.Point(307, 71);
            this.Product_List.Margin = new System.Windows.Forms.Padding(4);
            this.Product_List.Name = "Product_List";
            this.Product_List.Size = new System.Drawing.Size(129, 24);
            this.Product_List.TabIndex = 13;
            this.Product_List.SelectedIndexChanged += new System.EventHandler(this.Product_List_SelectedIndexChanged);
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Location = new System.Drawing.Point(44, 104);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(79, 17);
            this.disc.TabIndex = 12;
            this.disc.Text = "Description";
            this.disc.Click += new System.EventHandler(this.label27_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(304, 51);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 17);
            this.label36.TabIndex = 7;
            this.label36.Text = "Product name";
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // Discriptiontextbox
            // 
            this.Discriptiontextbox.Location = new System.Drawing.Point(47, 123);
            this.Discriptiontextbox.MaxLength = 5000;
            this.Discriptiontextbox.Name = "Discriptiontextbox";
            this.Discriptiontextbox.Size = new System.Drawing.Size(150, 22);
            this.Discriptiontextbox.TabIndex = 2;
            this.Discriptiontextbox.TextChanged += new System.EventHandler(this.PhonenumberTextbox_TextChanged);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label disc;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox Discriptiontextbox;
        private System.Windows.Forms.ComboBox Product_List;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label poduction;
        private System.Windows.Forms.TextBox ProductionCosttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountinstocktextBox;
        private System.Windows.Forms.Button updatedata;
        private System.Windows.Forms.Button Viewdatabutton;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button deleteProductbutton;
        private System.Windows.Forms.Button Reffreshdata;
    }
}