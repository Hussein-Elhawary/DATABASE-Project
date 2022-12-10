namespace Project
{
    partial class CustomerHomePage
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
            this.Logut_Button = new System.Windows.Forms.LinkLabel();
            this.ViewProfile_Button = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Buy_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderDetails_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Complaint_Button = new System.Windows.Forms.Button();
            this.ProductMenu_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Logut_Button
            // 
            this.Logut_Button.AutoSize = true;
            this.Logut_Button.BackColor = System.Drawing.Color.Navy;
            this.Logut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logut_Button.ForeColor = System.Drawing.Color.White;
            this.Logut_Button.LinkColor = System.Drawing.Color.White;
            this.Logut_Button.Location = new System.Drawing.Point(12, 18);
            this.Logut_Button.Name = "Logut_Button";
            this.Logut_Button.Size = new System.Drawing.Size(46, 13);
            this.Logut_Button.TabIndex = 2;
            this.Logut_Button.TabStop = true;
            this.Logut_Button.Text = "Logout";
            this.Logut_Button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewProfile_Button
            // 
            this.ViewProfile_Button.AutoSize = true;
            this.ViewProfile_Button.BackColor = System.Drawing.Color.Navy;
            this.ViewProfile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProfile_Button.ForeColor = System.Drawing.Color.White;
            this.ViewProfile_Button.LinkColor = System.Drawing.Color.White;
            this.ViewProfile_Button.Location = new System.Drawing.Point(531, 18);
            this.ViewProfile_Button.Name = "ViewProfile_Button";
            this.ViewProfile_Button.Size = new System.Drawing.Size(43, 13);
            this.ViewProfile_Button.TabIndex = 3;
            this.ViewProfile_Button.TabStop = true;
            this.ViewProfile_Button.Text = "Profile";
            this.ViewProfile_Button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewProfile_Button_LinkClicked);
            this.ViewProfile_Button.Click += new System.EventHandler(this.ViewProfile_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Navy;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(286, 18);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(33, 13);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "User";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.ViewProfile_Button);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Buy_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.OrderDetails_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Complaint_Button);
            this.panel1.Controls.Add(this.ProductMenu_Button);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 451);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Buy_button
            // 
            this.Buy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_button.Location = new System.Drawing.Point(489, 76);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(75, 23);
            this.Buy_button.TabIndex = 8;
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shopping Cart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 299);
            this.dataGridView1.TabIndex = 5;
            // 
            // OrderDetails_Button
            // 
            this.OrderDetails_Button.Location = new System.Drawing.Point(48, 320);
            this.OrderDetails_Button.Name = "OrderDetails_Button";
            this.OrderDetails_Button.Size = new System.Drawing.Size(126, 23);
            this.OrderDetails_Button.TabIndex = 4;
            this.OrderDetails_Button.Text = "View Orders";
            this.OrderDetails_Button.UseVisualStyleBackColor = true;
            this.OrderDetails_Button.Click += new System.EventHandler(this.OrderDetails_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Complaint_Button
            // 
            this.Complaint_Button.Location = new System.Drawing.Point(48, 155);
            this.Complaint_Button.Name = "Complaint_Button";
            this.Complaint_Button.Size = new System.Drawing.Size(126, 23);
            this.Complaint_Button.TabIndex = 3;
            this.Complaint_Button.Text = "Contact Support";
            this.Complaint_Button.UseVisualStyleBackColor = true;
            this.Complaint_Button.Click += new System.EventHandler(this.Complaint_Button_Click);
            // 
            // ProductMenu_Button
            // 
            this.ProductMenu_Button.Location = new System.Drawing.Point(48, 237);
            this.ProductMenu_Button.Name = "ProductMenu_Button";
            this.ProductMenu_Button.Size = new System.Drawing.Size(126, 23);
            this.ProductMenu_Button.TabIndex = 2;
            this.ProductMenu_Button.Text = "View and Buy Prodcuts";
            this.ProductMenu_Button.UseVisualStyleBackColor = true;
            this.ProductMenu_Button.Click += new System.EventHandler(this.ProductMenu_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-214, 429);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 449);
            this.Controls.Add(this.Logut_Button);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Logut_Button;
        private System.Windows.Forms.LinkLabel ViewProfile_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OrderDetails_Button;
        private System.Windows.Forms.Button Complaint_Button;
        private System.Windows.Forms.Button ProductMenu_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buy_button;
    }
}