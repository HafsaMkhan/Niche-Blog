namespace Niche_Blog
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdmin_Titlle = new System.Windows.Forms.TextBox();
            this.txtAccess_Code = new System.Windows.Forms.TextBox();
            this.cmdAccess = new System.Windows.Forms.Button();
            this.cmdMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 85);
            this.label1.TabIndex = 51;
            this.label1.Text = "NICHE BLOG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(255, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Access Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(255, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Admin ID ";
            // 
            // txtAdmin_Titlle
            // 
            this.txtAdmin_Titlle.Location = new System.Drawing.Point(412, 231);
            this.txtAdmin_Titlle.Name = "txtAdmin_Titlle";
            this.txtAdmin_Titlle.Size = new System.Drawing.Size(138, 22);
            this.txtAdmin_Titlle.TabIndex = 54;
            // 
            // txtAccess_Code
            // 
            this.txtAccess_Code.ForeColor = System.Drawing.Color.Indigo;
            this.txtAccess_Code.Location = new System.Drawing.Point(412, 267);
            this.txtAccess_Code.Name = "txtAccess_Code";
            this.txtAccess_Code.Size = new System.Drawing.Size(138, 22);
            this.txtAccess_Code.TabIndex = 55;
            this.txtAccess_Code.UseSystemPasswordChar = true;
            this.txtAccess_Code.TextChanged += new System.EventHandler(this.txtAccess_Code_TextChanged);
            // 
            // cmdAccess
            // 
            this.cmdAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAccess.Location = new System.Drawing.Point(435, 318);
            this.cmdAccess.Name = "cmdAccess";
            this.cmdAccess.Size = new System.Drawing.Size(114, 29);
            this.cmdAccess.TabIndex = 56;
            this.cmdAccess.Text = "Access";
            this.cmdAccess.UseVisualStyleBackColor = true;
            this.cmdAccess.Click += new System.EventHandler(this.cmdAccess_Click);
            // 
            // cmdMainPage
            // 
            this.cmdMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdMainPage.Location = new System.Drawing.Point(524, 139);
            this.cmdMainPage.Name = "cmdMainPage";
            this.cmdMainPage.Size = new System.Drawing.Size(170, 31);
            this.cmdMainPage.TabIndex = 57;
            this.cmdMainPage.Text = "Main Page";
            this.cmdMainPage.UseVisualStyleBackColor = true;
            this.cmdMainPage.Click += new System.EventHandler(this.cmdMainPage_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.cmdMainPage);
            this.Controls.Add(this.cmdAccess);
            this.Controls.Add(this.txtAccess_Code);
            this.Controls.Add(this.txtAdmin_Titlle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdmin_Titlle;
        private System.Windows.Forms.TextBox txtAccess_Code;
        private System.Windows.Forms.Button cmdAccess;
        private System.Windows.Forms.Button cmdMainPage;
    }
}