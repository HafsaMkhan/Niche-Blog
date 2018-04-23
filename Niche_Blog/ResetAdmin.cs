using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niche_Blog
{
    public partial class ResetAdmin : Form
    {
        private TabControl tabUserData;
        private TabPage tabuser_data;
        private TabPage tabblog_record;
        private TabPage tabreset_code;
        private TabPage tabadd_blog;
        private Button button1;
        private TextBox txtNCPass;
        private TextBox txtNewCode;
        private TextBox txtOldPwd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtAdmin;
        private TableLayoutPanel tableuser;
        private CheckBox checkBox1;
        private LinkLabel lnkAdminLogout;
        private Label label1;

        public ResetAdmin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.tabUserData = new System.Windows.Forms.TabControl();
            this.tabuser_data = new System.Windows.Forms.TabPage();
            this.tableuser = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabblog_record = new System.Windows.Forms.TabPage();
            this.tabreset_code = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNCPass = new System.Windows.Forms.TextBox();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabadd_blog = new System.Windows.Forms.TabPage();
            this.lnkAdminLogout = new System.Windows.Forms.LinkLabel();
            this.tabUserData.SuspendLayout();
            this.tabuser_data.SuspendLayout();
            this.tableuser.SuspendLayout();
            this.tabreset_code.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.TabIndex = 51;
            this.label1.Text = "NICHE BLOG";
            // 
            // tabUserData
            // 
            this.tabUserData.Controls.Add(this.tabuser_data);
            this.tabUserData.Controls.Add(this.tabblog_record);
            this.tabUserData.Controls.Add(this.tabreset_code);
            this.tabUserData.Controls.Add(this.tabadd_blog);
            this.tabUserData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabUserData.Location = new System.Drawing.Point(62, 115);
            this.tabUserData.Name = "tabUserData";
            this.tabUserData.SelectedIndex = 0;
            this.tabUserData.Size = new System.Drawing.Size(669, 365);
            this.tabUserData.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabUserData.TabIndex = 52;
            // 
            // tabuser_data
            // 
            this.tabuser_data.AutoScroll = true;
            this.tabuser_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabuser_data.BackgroundImage")));
            this.tabuser_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabuser_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabuser_data.Controls.Add(this.tableuser);
            this.tabuser_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabuser_data.ForeColor = System.Drawing.Color.Indigo;
            this.tabuser_data.Location = new System.Drawing.Point(4, 25);
            this.tabuser_data.Name = "tabuser_data";
            this.tabuser_data.Padding = new System.Windows.Forms.Padding(3);
            this.tabuser_data.Size = new System.Drawing.Size(661, 336);
            this.tabuser_data.TabIndex = 0;
            this.tabuser_data.Text = "User Data";
            this.tabuser_data.UseVisualStyleBackColor = true;
            // 
            // tableuser
            // 
            this.tableuser.ColumnCount = 4;
            this.tableuser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.20779F));
            this.tableuser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.79221F));
            this.tableuser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableuser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableuser.Controls.Add(this.checkBox1, 3, 1);
            this.tableuser.Location = new System.Drawing.Point(70, 49);
            this.tableuser.Name = "tableuser";
            this.tableuser.RowCount = 6;
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableuser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableuser.Size = new System.Drawing.Size(513, 223);
            this.tableuser.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(463, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(13, 12);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabblog_record
            // 
            this.tabblog_record.AutoScroll = true;
            this.tabblog_record.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabblog_record.BackgroundImage")));
            this.tabblog_record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabblog_record.ForeColor = System.Drawing.Color.Indigo;
            this.tabblog_record.Location = new System.Drawing.Point(4, 22);
            this.tabblog_record.Name = "tabblog_record";
            this.tabblog_record.Padding = new System.Windows.Forms.Padding(3);
            this.tabblog_record.Size = new System.Drawing.Size(661, 339);
            this.tabblog_record.TabIndex = 1;
            this.tabblog_record.Text = "Blog Record";
            this.tabblog_record.UseVisualStyleBackColor = true;
            // 
            // tabreset_code
            // 
            this.tabreset_code.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabreset_code.BackgroundImage")));
            this.tabreset_code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabreset_code.Controls.Add(this.label5);
            this.tabreset_code.Controls.Add(this.txtAdmin);
            this.tabreset_code.Controls.Add(this.button1);
            this.tabreset_code.Controls.Add(this.txtNCPass);
            this.tabreset_code.Controls.Add(this.txtNewCode);
            this.tabreset_code.Controls.Add(this.txtOldPwd);
            this.tabreset_code.Controls.Add(this.label4);
            this.tabreset_code.Controls.Add(this.label3);
            this.tabreset_code.Controls.Add(this.label2);
            this.tabreset_code.ForeColor = System.Drawing.Color.Indigo;
            this.tabreset_code.Location = new System.Drawing.Point(4, 25);
            this.tabreset_code.Name = "tabreset_code";
            this.tabreset_code.Padding = new System.Windows.Forms.Padding(3);
            this.tabreset_code.Size = new System.Drawing.Size(661, 336);
            this.tabreset_code.TabIndex = 2;
            this.tabreset_code.Text = "Reset Code";
            this.tabreset_code.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Admin ID";
            // 
            // txtAdmin
            // 
            this.txtAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdmin.ForeColor = System.Drawing.Color.Indigo;
            this.txtAdmin.Location = new System.Drawing.Point(333, 100);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(163, 22);
            this.txtAdmin.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(385, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 72;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtNCPass
            // 
            this.txtNCPass.BackColor = System.Drawing.Color.SeaShell;
            this.txtNCPass.ForeColor = System.Drawing.Color.Indigo;
            this.txtNCPass.Location = new System.Drawing.Point(333, 212);
            this.txtNCPass.Name = "txtNCPass";
            this.txtNCPass.Size = new System.Drawing.Size(162, 22);
            this.txtNCPass.TabIndex = 71;
            this.txtNCPass.UseSystemPasswordChar = true;
            this.txtNCPass.TextChanged += new System.EventHandler(this.txtNCPass_TextChanged);
            // 
            // txtNewCode
            // 
            this.txtNewCode.BackColor = System.Drawing.Color.SeaShell;
            this.txtNewCode.ForeColor = System.Drawing.Color.Indigo;
            this.txtNewCode.Location = new System.Drawing.Point(333, 173);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(163, 22);
            this.txtNewCode.TabIndex = 70;
            this.txtNewCode.UseSystemPasswordChar = true;
            this.txtNewCode.TextChanged += new System.EventHandler(this.txtNewCode_TextChanged);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.BackColor = System.Drawing.Color.SeaShell;
            this.txtOldPwd.ForeColor = System.Drawing.Color.Indigo;
            this.txtOldPwd.Location = new System.Drawing.Point(333, 139);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(163, 22);
            this.txtOldPwd.TabIndex = 69;
            this.txtOldPwd.UseSystemPasswordChar = true;
            this.txtOldPwd.TextChanged += new System.EventHandler(this.txtOldPwd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(171, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Confirm Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(168, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "New Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(165, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Old Code";
            // 
            // tabadd_blog
            // 
            this.tabadd_blog.AutoScroll = true;
            this.tabadd_blog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabadd_blog.BackgroundImage")));
            this.tabadd_blog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabadd_blog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabadd_blog.ForeColor = System.Drawing.Color.Indigo;
            this.tabadd_blog.Location = new System.Drawing.Point(4, 22);
            this.tabadd_blog.Name = "tabadd_blog";
            this.tabadd_blog.Padding = new System.Windows.Forms.Padding(3);
            this.tabadd_blog.Size = new System.Drawing.Size(661, 339);
            this.tabadd_blog.TabIndex = 3;
            this.tabadd_blog.Text = "Add Blog";
            this.tabadd_blog.UseVisualStyleBackColor = true;
            // 
            // lnkAdminLogout
            // 
            this.lnkAdminLogout.AutoSize = true;
            this.lnkAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAdminLogout.LinkColor = System.Drawing.Color.Purple;
            this.lnkAdminLogout.Location = new System.Drawing.Point(576, 49);
            this.lnkAdminLogout.Name = "lnkAdminLogout";
            this.lnkAdminLogout.Size = new System.Drawing.Size(65, 20);
            this.lnkAdminLogout.TabIndex = 53;
            this.lnkAdminLogout.TabStop = true;
            this.lnkAdminLogout.Text = "Logout";
            // 
            // ResetAdmin
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.lnkAdminLogout);
            this.Controls.Add(this.tabUserData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "ResetAdmin";
            this.tabUserData.ResumeLayout(false);
            this.tabuser_data.ResumeLayout(false);
            this.tableuser.ResumeLayout(false);
            this.tableuser.PerformLayout();
            this.tabreset_code.ResumeLayout(false);
            this.tabreset_code.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            bool valid, validate;
            
            if (txtAdmin.Text==""||txtNCPass.Text == "" ||txtNewCode.Text == "" ||txtOldPwd.Text == "")
            {
                MessageBox.Show("Incomplete information!");
            }
            server.Service1 server = new server.Service1();
            server.Reset(txtAdmin.Text, txtOldPwd.Text, txtNewCode.Text, txtNCPass.Text, out valid, out validate);
            if(validate==true & valid == true)
            {
                if (txtNewCode.Text == txtNCPass.Text)
                {
                    MessageBox.Show("Code reseted successfully.");
                }
                else
                {
                    MessageBox.Show("Code does not match.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID and Code!");
            }
        }

        private void txtOldPwd_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtOldPwd.Text, out value))
            {
                
            }
            else
            {
                MessageBox.Show("Numeric inputs are valid only.");
            }
        }

        private void txtNewCode_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtNewCode.Text, out value))
            {
                
            }
            else
            {
                MessageBox.Show("Numeric inputs are valid only.");
            }
        }

        private void txtNCPass_TextChanged(object sender, EventArgs e)
        {
            int value;
            
            if (int.TryParse(txtOldPwd.Text, out value))
            {

            }
            else
            {
                MessageBox.Show("Numeric inputs are valid only.");
            }
        }
    }
}
