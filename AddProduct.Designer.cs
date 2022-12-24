namespace Project
{
    partial class AddProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProductnametextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AmountinstocktextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductioncosttextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaterialsCombobox = new System.Windows.Forms.ComboBox();
            this.InsertMaterialbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 246;
            this.button1.Text = "Add product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductnametextBox
            // 
            this.ProductnametextBox.Location = new System.Drawing.Point(419, 92);
            this.ProductnametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductnametextBox.MaxLength = 50;
            this.ProductnametextBox.Name = "ProductnametextBox";
            this.ProductnametextBox.Size = new System.Drawing.Size(96, 22);
            this.ProductnametextBox.TabIndex = 245;
            this.ProductnametextBox.TextChanged += new System.EventHandler(this.ProductnametextBox_TextChanged);
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(419, 153);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(96, 22);
            this.PricetextBox.TabIndex = 244;
            this.PricetextBox.TextChanged += new System.EventHandler(this.PricetextBox_TextChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(419, 220);
            this.DescriptiontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptiontextBox.MaxLength = 5000;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(96, 22);
            this.DescriptiontextBox.TabIndex = 234;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 240;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 239;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 238;
            this.label3.Text = "Product Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(63, -50);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 119);
            this.panel3.TabIndex = 237;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(737, -51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 553);
            this.panel2.TabIndex = 236;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(-134, -51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 553);
            this.panel1.TabIndex = 235;
            // 
            // AmountinstocktextBox
            // 
            this.AmountinstocktextBox.Location = new System.Drawing.Point(419, 292);
            this.AmountinstocktextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AmountinstocktextBox.MaxLength = 50;
            this.AmountinstocktextBox.Name = "AmountinstocktextBox";
            this.AmountinstocktextBox.Size = new System.Drawing.Size(96, 22);
            this.AmountinstocktextBox.TabIndex = 247;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 248;
            this.label2.Text = "Amount in stock";
            // 
            // ProductioncosttextBox
            // 
            this.ProductioncosttextBox.Location = new System.Drawing.Point(419, 360);
            this.ProductioncosttextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductioncosttextBox.MaxLength = 50;
            this.ProductioncosttextBox.Name = "ProductioncosttextBox";
            this.ProductioncosttextBox.Size = new System.Drawing.Size(96, 22);
            this.ProductioncosttextBox.TabIndex = 249;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 250;
            this.label7.Text = "Production cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 251;
            this.label6.Text = "Materials used";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(138, 163);
            this.dataGridView1.TabIndex = 252;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaterialsCombobox
            // 
            this.MaterialsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialsCombobox.FormattingEnabled = true;
            this.MaterialsCombobox.Location = new System.Drawing.Point(419, 405);
            this.MaterialsCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialsCombobox.Name = "MaterialsCombobox";
            this.MaterialsCombobox.Size = new System.Drawing.Size(96, 24);
            this.MaterialsCombobox.TabIndex = 253;
            this.MaterialsCombobox.SelectedIndexChanged += new System.EventHandler(this.Product_List_SelectedIndexChanged);
            // 
            // InsertMaterialbutton
            // 
            this.InsertMaterialbutton.Location = new System.Drawing.Point(578, 242);
            this.InsertMaterialbutton.Name = "InsertMaterialbutton";
            this.InsertMaterialbutton.Size = new System.Drawing.Size(138, 23);
            this.InsertMaterialbutton.TabIndex = 254;
            this.InsertMaterialbutton.Text = "Insert Maretial";
            this.InsertMaterialbutton.UseVisualStyleBackColor = true;
            this.InsertMaterialbutton.Click += new System.EventHandler(this.InsertMaterialbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Project.Properties.Resources.imgbin_computer_icons_home_button_sign_home_MkjkgcTaBkXHYRzyyEgLbmQ2m;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(68, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 42);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertMaterialbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaterialsCombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductioncosttextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AmountinstocktextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductnametextBox);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProductnametextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox AmountinstocktextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductioncosttextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MaterialsCombobox;
        private System.Windows.Forms.Button InsertMaterialbutton;
    }
}