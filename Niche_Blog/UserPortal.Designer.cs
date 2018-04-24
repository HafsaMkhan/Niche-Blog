﻿namespace Niche_Blog
{
    partial class UserPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPortal));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkRead = new System.Windows.Forms.LinkLabel();
            this.lnkResetPass = new System.Windows.Forms.LinkLabel();
            this.lnkUpload = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdimage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblShowUser = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 54;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(264, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 55;
            this.button1.Text = "Upload Blog";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(452, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 56;
            this.button2.Text = "Read Blog";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(554, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 57;
            // 
            // lnkLogout
            // 
            this.lnkLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLogout.DisabledLinkColor = System.Drawing.Color.Navy;
            this.lnkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogout.LinkColor = System.Drawing.Color.Purple;
            this.lnkLogout.Location = new System.Drawing.Point(762, 125);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(59, 20);
            this.lnkLogout.TabIndex = 77;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lnkRead
            // 
            this.lnkRead.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkRead.AutoSize = true;
            this.lnkRead.BackColor = System.Drawing.Color.Transparent;
            this.lnkRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRead.DisabledLinkColor = System.Drawing.Color.Navy;
            this.lnkRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRead.LinkColor = System.Drawing.Color.Purple;
            this.lnkRead.Location = new System.Drawing.Point(439, 125);
            this.lnkRead.Name = "lnkRead";
            this.lnkRead.Size = new System.Drawing.Size(84, 20);
            this.lnkRead.TabIndex = 76;
            this.lnkRead.TabStop = true;
            this.lnkRead.Text = "Read Blog";
            // 
            // lnkResetPass
            // 
            this.lnkResetPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkResetPass.AutoSize = true;
            this.lnkResetPass.BackColor = System.Drawing.Color.Transparent;
            this.lnkResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkResetPass.DisabledLinkColor = System.Drawing.Color.Navy;
            this.lnkResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkResetPass.LinkColor = System.Drawing.Color.Purple;
            this.lnkResetPass.Location = new System.Drawing.Point(631, 125);
            this.lnkResetPass.Name = "lnkResetPass";
            this.lnkResetPass.Size = new System.Drawing.Size(125, 20);
            this.lnkResetPass.TabIndex = 75;
            this.lnkResetPass.TabStop = true;
            this.lnkResetPass.Text = "Reset Password";
            this.lnkResetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResetPass_LinkClicked);
            // 
            // lnkUpload
            // 
            this.lnkUpload.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkUpload.AutoSize = true;
            this.lnkUpload.BackColor = System.Drawing.Color.Transparent;
            this.lnkUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkUpload.DisabledLinkColor = System.Drawing.Color.Navy;
            this.lnkUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpload.LinkColor = System.Drawing.Color.Purple;
            this.lnkUpload.Location = new System.Drawing.Point(529, 125);
            this.lnkUpload.Name = "lnkUpload";
            this.lnkUpload.Size = new System.Drawing.Size(96, 20);
            this.lnkUpload.TabIndex = 74;
            this.lnkUpload.TabStop = true;
            this.lnkUpload.Text = "Upload Blog";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.SeaShell;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Navy;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel2.Location = new System.Drawing.Point(467, 132);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 20);
            this.linkLabel2.TabIndex = 73;
            // 
            // lnkHome
            // 
            this.lnkHome.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkHome.AutoSize = true;
            this.lnkHome.BackColor = System.Drawing.Color.Transparent;
            this.lnkHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkHome.DisabledLinkColor = System.Drawing.Color.Navy;
            this.lnkHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHome.LinkColor = System.Drawing.Color.Purple;
            this.lnkHome.Location = new System.Drawing.Point(381, 125);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(52, 20);
            this.lnkHome.TabIndex = 72;
            this.lnkHome.TabStop = true;
            this.lnkHome.Text = "Home";
            this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHome_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 85);
            this.label1.TabIndex = 71;
            this.label1.Text = "NICHE BLOG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "User Interests";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cmdimage
            // 
            this.cmdimage.BackColor = System.Drawing.Color.Bisque;
            this.cmdimage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdimage.Location = new System.Drawing.Point(578, 411);
            this.cmdimage.Name = "cmdimage";
            this.cmdimage.Size = new System.Drawing.Size(126, 31);
            this.cmdimage.TabIndex = 82;
            this.cmdimage.Text = "Upload Picture";
            this.cmdimage.UseVisualStyleBackColor = false;
            this.cmdimage.Click += new System.EventHandler(this.cmdimage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(570, 234);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(151, 171);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 83;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblInterest});
            this.dataGridView1.GridColor = System.Drawing.Color.Indigo;
            this.dataGridView1.Location = new System.Drawing.Point(127, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(145, 208);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblShowUser
            // 
            this.lblShowUser.AutoSize = true;
            this.lblShowUser.BackColor = System.Drawing.Color.Transparent;
            this.lblShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUser.Location = new System.Drawing.Point(59, 136);
            this.lblShowUser.Name = "lblShowUser";
            this.lblShowUser.Size = new System.Drawing.Size(34, 29);
            this.lblShowUser.TabIndex = 85;
            this.lblShowUser.Text = "lll";
            this.lblShowUser.Click += new System.EventHandler(this.lblShowUser_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.HeaderText = "Interests";
            this.lblInterest.MaxInputLength = 32790;
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.ReadOnly = true;
            // 
            // UserPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 574);
            this.Controls.Add(this.lblShowUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cmdimage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkRead);
            this.Controls.Add(this.lnkResetPass);
            this.Controls.Add(this.lnkUpload);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lnkHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPortal";
            this.Text = "UserPortal";
            this.Load += new System.EventHandler(this.UserPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkRead;
        private System.Windows.Forms.LinkLabel lnkResetPass;
        private System.Windows.Forms.LinkLabel lnkUpload;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdimage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblShowUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblInterest;
    }
}