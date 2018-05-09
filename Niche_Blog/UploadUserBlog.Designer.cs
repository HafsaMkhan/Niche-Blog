namespace Niche_Blog
{
    partial class UploadUserBlog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadUserBlog));
            this.lblShowUser = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkRead = new System.Windows.Forms.LinkLabel();
            this.lnkResetPass = new System.Windows.Forms.LinkLabel();
            this.lnkUpload = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataReadBlog = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReadBlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowUser
            // 
            this.lblShowUser.AutoSize = true;
            this.lblShowUser.BackColor = System.Drawing.Color.Transparent;
            this.lblShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowUser.Location = new System.Drawing.Point(59, 128);
            this.lblShowUser.Name = "lblShowUser";
            this.lblShowUser.Size = new System.Drawing.Size(0, 29);
            this.lblShowUser.TabIndex = 93;
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
            this.lnkLogout.Location = new System.Drawing.Point(762, 117);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(59, 20);
            this.lnkLogout.TabIndex = 92;
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
            this.lnkRead.Location = new System.Drawing.Point(421, 117);
            this.lnkRead.Name = "lnkRead";
            this.lnkRead.Size = new System.Drawing.Size(84, 20);
            this.lnkRead.TabIndex = 91;
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
            this.lnkResetPass.Location = new System.Drawing.Point(631, 117);
            this.lnkResetPass.Name = "lnkResetPass";
            this.lnkResetPass.Size = new System.Drawing.Size(125, 20);
            this.lnkResetPass.TabIndex = 90;
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
            this.lnkUpload.Location = new System.Drawing.Point(511, 117);
            this.lnkUpload.Name = "lnkUpload";
            this.lnkUpload.Size = new System.Drawing.Size(114, 20);
            this.lnkUpload.TabIndex = 89;
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
            this.lnkHome.Location = new System.Drawing.Point(363, 117);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(52, 20);
            this.lnkHome.TabIndex = 88;
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 85);
            this.label1.TabIndex = 87;
            this.label1.Text = "NICHE BLOG";
            // 
            // dataReadBlog
            // 
            this.dataReadBlog.AllowDrop = true;
            this.dataReadBlog.AllowUserToAddRows = false;
            this.dataReadBlog.AllowUserToResizeColumns = false;
            this.dataReadBlog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReadBlog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataReadBlog.AutoGenerateColumns = false;
            this.dataReadBlog.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataReadBlog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReadBlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataReadBlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReadBlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.Check_Edit});
            this.dataReadBlog.DataSource = this.blogBindingSource;
            this.dataReadBlog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataReadBlog.GridColor = System.Drawing.Color.SeaShell;
            this.dataReadBlog.Location = new System.Drawing.Point(64, 170);
            this.dataReadBlog.MultiSelect = false;
            this.dataReadBlog.Name = "dataReadBlog";
            this.dataReadBlog.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            this.dataReadBlog.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataReadBlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataReadBlog.ShowCellToolTips = false;
            this.dataReadBlog.ShowEditingIcon = false;
            this.dataReadBlog.Size = new System.Drawing.Size(721, 326);
            this.dataReadBlog.TabIndex = 102;
            this.dataReadBlog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReadBlog_CellContentClick);
            this.dataReadBlog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReadBlog_CellDoubleClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.titleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 250;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 200;
            // 
            // Check_Edit
            // 
            this.Check_Edit.DataPropertyName = "edit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.Check_Edit.DefaultCellStyle = dataGridViewCellStyle6;
            this.Check_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_Edit.HeaderText = "Edit";
            this.Check_Edit.Name = "Check_Edit";
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(Niche_Blog.server.Blog);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.SeaShell;
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(661, 502);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(124, 34);
            this.cmdEdit.TabIndex = 103;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = false;
            this.cmdEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // UploadUserBlog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 548);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.dataReadBlog);
            this.Controls.Add(this.lblShowUser);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkRead);
            this.Controls.Add(this.lnkResetPass);
            this.Controls.Add(this.lnkUpload);
            this.Controls.Add(this.lnkHome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadUserBlog";
            this.Text = "UploadUserBlog";
            this.Load += new System.EventHandler(this.UploadUserBlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReadBlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowUser;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkRead;
        private System.Windows.Forms.LinkLabel lnkResetPass;
        private System.Windows.Forms.LinkLabel lnkUpload;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataReadBlog;
        private System.Windows.Forms.BindingSource blogBindingSource;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check_Edit;
    }
}