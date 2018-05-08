namespace Niche_Blog
{
    partial class EditBlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBlog));
            this.cmdFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // cmdFont
            // 
            this.cmdFont.BackColor = System.Drawing.Color.SeaShell;
            this.cmdFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFont.ForeColor = System.Drawing.Color.Indigo;
            this.cmdFont.Location = new System.Drawing.Point(605, 161);
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(135, 30);
            this.cmdFont.TabIndex = 122;
            this.cmdFont.Text = "Chnage Font";
            this.cmdFont.UseVisualStyleBackColor = false;
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(-4, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 85);
            this.label1.TabIndex = 115;
            this.label1.Text = "NICHE BLOG";
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(11, 231);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(767, 327);
            this.txtDetail.TabIndex = 114;
            this.txtDetail.Text = "";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Indigo;
            this.lblType.Location = new System.Drawing.Point(49, 152);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 124;
            // 
            // cmdUpload
            // 
            this.cmdUpload.BackColor = System.Drawing.Color.SeaShell;
            this.cmdUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.ForeColor = System.Drawing.Color.Indigo;
            this.cmdUpload.Location = new System.Drawing.Point(619, 564);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(135, 30);
            this.cmdUpload.TabIndex = 127;
            this.cmdUpload.Text = "Upload";
            this.cmdUpload.UseVisualStyleBackColor = false;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(49, 109);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 123;
            // 
            // EditBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 622);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditBlog";
            this.Text = "EditBlog";
            this.Load += new System.EventHandler(this.EditBlog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}