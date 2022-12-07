﻿namespace Project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ViewProfile_Button.Location = new System.Drawing.Point(745, 18);
            this.ViewProfile_Button.Name = "ViewProfile_Button";
            this.ViewProfile_Button.Size = new System.Drawing.Size(43, 13);
            this.ViewProfile_Button.TabIndex = 3;
            this.ViewProfile_Button.TabStop = true;
            this.ViewProfile_Button.Text = "Profile";
            this.ViewProfile_Button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewProfile_Button_LinkClicked);
            this.ViewProfile_Button.Click += new System.EventHandler(this.ViewProfile_Button_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Navy;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(410, 18);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(33, 13);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 451);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 429);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewProfile_Button);
            this.Controls.Add(this.Logut_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}