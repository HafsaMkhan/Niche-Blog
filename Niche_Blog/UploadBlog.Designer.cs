namespace Niche_Blog
{
    partial class UploadBlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadBlog));
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.lblShowUser = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkRead = new System.Windows.Forms.LinkLabel();
            this.lnkResetPass = new System.Windows.Forms.LinkLabel();
            this.lnkUpload = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(27, 248);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(767, 327);
            this.txtDetail.TabIndex = 0;
            this.txtDetail.Text = "";
            // 
            // lblShowUser
            // 
            this.lblShowUser.AutoSize = true;
            this.lblShowUser.BackColor = System.Drawing.Color.Transparent;
            this.lblShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUser.Location = new System.Drawing.Point(59, 118);
            this.lblShowUser.Name = "lblShowUser";
            this.lblShowUser.Size = new System.Drawing.Size(0, 29);
            this.lblShowUser.TabIndex = 107;
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
            this.lnkLogout.Location = new System.Drawing.Point(762, 107);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(59, 20);
            this.lnkLogout.TabIndex = 106;
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
            this.lnkRead.Location = new System.Drawing.Point(421, 107);
            this.lnkRead.Name = "lnkRead";
            this.lnkRead.Size = new System.Drawing.Size(84, 20);
            this.lnkRead.TabIndex = 105;
            this.lnkRead.TabStop = true;
            this.lnkRead.Text = "Read Blog";
            this.lnkRead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRead_LinkClicked);
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
            this.lnkResetPass.Location = new System.Drawing.Point(631, 107);
            this.lnkResetPass.Name = "lnkResetPass";
            this.lnkResetPass.Size = new System.Drawing.Size(125, 20);
            this.lnkResetPass.TabIndex = 104;
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
            this.lnkUpload.Location = new System.Drawing.Point(511, 107);
            this.lnkUpload.Name = "lnkUpload";
            this.lnkUpload.Size = new System.Drawing.Size(114, 20);
            this.lnkUpload.TabIndex = 103;
            this.lnkUpload.TabStop = true;
            this.lnkUpload.Text = "Uploaded Blog";
            this.lnkUpload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpload_LinkClicked);
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
            this.lnkHome.Location = new System.Drawing.Point(363, 107);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(52, 20);
            this.lnkHome.TabIndex = 102;
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 85);
            this.label1.TabIndex = 101;
            this.label1.Text = "NICHE BLOG";
            // 
            // cmdFont
            // 
            this.cmdFont.BackColor = System.Drawing.Color.SeaShell;
            this.cmdFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFont.ForeColor = System.Drawing.Color.Indigo;
            this.cmdFont.Location = new System.Drawing.Point(621, 178);
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(135, 30);
            this.cmdFont.TabIndex = 108;
            this.cmdFont.Text = "Chnage Font";
            this.cmdFont.UseVisualStyleBackColor = false;
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(34, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 109;
            this.label2.Text = "Blog Title ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(34, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Genre";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(137, 161);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(378, 20);
            this.txtTitle.TabIndex = 111;
            // 
            // txtGenre
            // 
            this.txtGenre.FormattingEnabled = true;
            this.txtGenre.Items.AddRange(new object[] {
            "Social Life",
            "Medicine",
            "Health & Fitness",
            "Business",
            "Food",
            "Studies",
            "Freelancing",
            "Media Blogs",
            "Current Affairs"});
            this.txtGenre.Location = new System.Drawing.Point(139, 206);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(376, 21);
            this.txtGenre.TabIndex = 112;
            // 
            // cmdUpload
            // 
            this.cmdUpload.BackColor = System.Drawing.Color.SeaShell;
            this.cmdUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.ForeColor = System.Drawing.Color.Indigo;
            this.cmdUpload.Location = new System.Drawing.Point(635, 581);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(135, 30);
            this.cmdUpload.TabIndex = 113;
            this.cmdUpload.Text = "Upload";
            this.cmdUpload.UseVisualStyleBackColor = false;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // UploadBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 620);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdFont);
            this.Controls.Add(this.lblShowUser);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkRead);
            this.Controls.Add(this.lnkResetPass);
            this.Controls.Add(this.lnkUpload);
            this.Controls.Add(this.lnkHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadBlog";
            this.Text = "UploadBlog";
            this.Load += new System.EventHandler(this.UploadBlog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label lblShowUser;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkRead;
        private System.Windows.Forms.LinkLabel lnkResetPass;
        private System.Windows.Forms.LinkLabel lnkUpload;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox txtGenre;
        private System.Windows.Forms.Button cmdUpload;
    }
}