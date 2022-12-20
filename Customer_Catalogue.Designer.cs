namespace Project
{
    partial class Customer_Catalogue
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Product_List = new System.Windows.Forms.ComboBox();
            this.AddToCart_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Return_Label = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(469, 69);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(347, 72);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Search_TextBox.TabIndex = 2;
            // 
            // Product_List
            // 
            this.Product_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_List.FormattingEnabled = true;
            this.Product_List.Location = new System.Drawing.Point(28, 72);
            this.Product_List.Name = "Product_List";
            this.Product_List.Size = new System.Drawing.Size(121, 21);
            this.Product_List.TabIndex = 3;
            // 
            // AddToCart_Button
            // 
            this.AddToCart_Button.Location = new System.Drawing.Point(175, 72);
            this.AddToCart_Button.Name = "AddToCart_Button";
            this.AddToCart_Button.Size = new System.Drawing.Size(83, 23);
            this.AddToCart_Button.TabIndex = 4;
            this.AddToCart_Button.Text = "Add to Cart";
            this.AddToCart_Button.UseVisualStyleBackColor = true;
            this.AddToCart_Button.Click += new System.EventHandler(this.AddToCart_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catalogue";
            // 
            // Return_Label
            // 
            this.Return_Label.AutoSize = true;
            this.Return_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Return_Label.Location = new System.Drawing.Point(12, 9);
            this.Return_Label.Name = "Return_Label";
            this.Return_Label.Size = new System.Drawing.Size(39, 13);
            this.Return_Label.TabIndex = 6;
            this.Return_Label.TabStop = true;
            this.Return_Label.Text = "Return";
            this.Return_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_Label_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 438);
            this.panel1.TabIndex = 7;
            // 
            // Customer_Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 430);
            this.Controls.Add(this.Return_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToCart_Button);
            this.Controls.Add(this.Product_List);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Catalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.Customer_Catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.ComboBox Product_List;
        private System.Windows.Forms.Button AddToCart_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Return_Label;
        private System.Windows.Forms.Panel panel1;
    }
}