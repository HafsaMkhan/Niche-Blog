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
        private LinkLabel lnkAdminLogout;
        private Button cmdDeleteUser;
        private DataGridView dataAdminUserData;
        private Button cmdDeleteBlog;
        private DataGridView dataAdminBlogData;
        private Button cmdAdd;
        private RichTextBox txtDetails;
        private Label label7;
        private Label label6;
        private TextBox txtTitle;
        private ComboBox txtType;
        private IContainer components;
        private BindingSource blogBindingSource;
        private DataGridViewTextBoxColumn dataTitleBlog;
        private DataGridViewTextBoxColumn dataGenre;
        private DataGridViewTextBoxColumn dataAuthor;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secretQuestionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imgDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Label label1;

        public ResetAdmin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUserData = new System.Windows.Forms.TabControl();
            this.tabuser_data = new System.Windows.Forms.TabPage();
            this.cmdDeleteUser = new System.Windows.Forms.Button();
            this.dataAdminUserData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabblog_record = new System.Windows.Forms.TabPage();
            this.cmdDeleteBlog = new System.Windows.Forms.Button();
            this.dataAdminBlogData = new System.Windows.Forms.DataGridView();
            this.dataTitleBlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lnkAdminLogout = new System.Windows.Forms.LinkLabel();
            this.tabUserData.SuspendLayout();
            this.tabuser_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabblog_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminBlogData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            this.tabreset_code.SuspendLayout();
            this.tabadd_blog.SuspendLayout();
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
            this.tabUserData.Location = new System.Drawing.Point(27, 115);
            this.tabUserData.Name = "tabUserData";
            this.tabUserData.SelectedIndex = 0;
            this.tabUserData.Size = new System.Drawing.Size(748, 433);
            this.tabUserData.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabUserData.TabIndex = 52;
            // 
            // tabuser_data
            // 
            this.tabuser_data.AutoScroll = true;
            this.tabuser_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabuser_data.BackgroundImage")));
            this.tabuser_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabuser_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabuser_data.Controls.Add(this.cmdDeleteUser);
            this.tabuser_data.Controls.Add(this.dataAdminUserData);
            this.tabuser_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabuser_data.ForeColor = System.Drawing.Color.Indigo;
            this.tabuser_data.Location = new System.Drawing.Point(4, 25);
            this.tabuser_data.Name = "tabuser_data";
            this.tabuser_data.Padding = new System.Windows.Forms.Padding(3);
            this.tabuser_data.Size = new System.Drawing.Size(740, 404);
            this.tabuser_data.TabIndex = 0;
            this.tabuser_data.Text = "User Data";
            this.tabuser_data.UseVisualStyleBackColor = true;
            this.tabuser_data.Click += new System.EventHandler(this.tabuser_data_Click);
            // 
            // cmdDeleteUser
            // 
            this.cmdDeleteUser.BackColor = System.Drawing.Color.SeaShell;
            this.cmdDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDeleteUser.Location = new System.Drawing.Point(573, 352);
            this.cmdDeleteUser.Name = "cmdDeleteUser";
            this.cmdDeleteUser.Size = new System.Drawing.Size(133, 27);
            this.cmdDeleteUser.TabIndex = 4;
            this.cmdDeleteUser.Text = "Delete";
            this.cmdDeleteUser.UseVisualStyleBackColor = false;
            this.cmdDeleteUser.Click += new System.EventHandler(this.cmdDeleteUser_Click);
            // 
            // dataAdminUserData
            // 
            this.dataAdminUserData.AllowDrop = true;
            this.dataAdminUserData.AllowUserToAddRows = false;
            this.dataAdminUserData.AllowUserToDeleteRows = false;
            this.dataAdminUserData.AllowUserToResizeColumns = false;
            this.dataAdminUserData.AllowUserToResizeRows = false;
            this.dataAdminUserData.AutoGenerateColumns = false;
            this.dataAdminUserData.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAdminUserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAdminUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdminUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.secretQuestionDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.imgDataGridViewTextBoxColumn});
            this.dataAdminUserData.DataSource = this.userBindingSource;
            this.dataAdminUserData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAdminUserData.Location = new System.Drawing.Point(26, 33);
            this.dataAdminUserData.Name = "dataAdminUserData";
            this.dataAdminUserData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataAdminUserData.RowHeadersVisible = false;
            this.dataAdminUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAdminUserData.ShowEditingIcon = false;
            this.dataAdminUserData.Size = new System.Drawing.Size(693, 301);
            this.dataAdminUserData.TabIndex = 0;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usernameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 250;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // secretQuestionDataGridViewTextBoxColumn
            // 
            this.secretQuestionDataGridViewTextBoxColumn.DataPropertyName = "secretQuestion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secretQuestionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.secretQuestionDataGridViewTextBoxColumn.HeaderText = "Secret Question";
            this.secretQuestionDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.secretQuestionDataGridViewTextBoxColumn.Name = "secretQuestionDataGridViewTextBoxColumn";
            this.secretQuestionDataGridViewTextBoxColumn.Width = 200;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.answerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 150;
            // 
            // imgDataGridViewTextBoxColumn
            // 
            this.imgDataGridViewTextBoxColumn.DataPropertyName = "img";
            this.imgDataGridViewTextBoxColumn.HeaderText = "User DP";
            this.imgDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.imgDataGridViewTextBoxColumn.Name = "imgDataGridViewTextBoxColumn";
            this.imgDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Niche_Blog.server.User);
            // 
            // tabblog_record
            // 
            this.tabblog_record.AutoScroll = true;
            this.tabblog_record.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabblog_record.BackgroundImage")));
            this.tabblog_record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabblog_record.Controls.Add(this.cmdDeleteBlog);
            this.tabblog_record.Controls.Add(this.dataAdminBlogData);
            this.tabblog_record.ForeColor = System.Drawing.Color.Indigo;
            this.tabblog_record.Location = new System.Drawing.Point(4, 22);
            this.tabblog_record.Name = "tabblog_record";
            this.tabblog_record.Padding = new System.Windows.Forms.Padding(3);
            this.tabblog_record.Size = new System.Drawing.Size(740, 407);
            this.tabblog_record.TabIndex = 1;
            this.tabblog_record.Text = "Blog Record";
            this.tabblog_record.UseVisualStyleBackColor = true;
            this.tabblog_record.Click += new System.EventHandler(this.tabblog_record_Click);
            // 
            // cmdDeleteBlog
            // 
            this.cmdDeleteBlog.BackColor = System.Drawing.Color.SeaShell;
            this.cmdDeleteBlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDeleteBlog.Location = new System.Drawing.Point(581, 346);
            this.cmdDeleteBlog.Name = "cmdDeleteBlog";
            this.cmdDeleteBlog.Size = new System.Drawing.Size(133, 27);
            this.cmdDeleteBlog.TabIndex = 3;
            this.cmdDeleteBlog.Text = "Delete";
            this.cmdDeleteBlog.UseVisualStyleBackColor = false;
            this.cmdDeleteBlog.Click += new System.EventHandler(this.cmdDeleteBlog_Click);
            // 
            // dataAdminBlogData
            // 
            this.dataAdminBlogData.AllowDrop = true;
            this.dataAdminBlogData.AllowUserToAddRows = false;
            this.dataAdminBlogData.AllowUserToDeleteRows = false;
            this.dataAdminBlogData.AllowUserToResizeColumns = false;
            this.dataAdminBlogData.AllowUserToResizeRows = false;
            this.dataAdminBlogData.AutoGenerateColumns = false;
            this.dataAdminBlogData.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataAdminBlogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdminBlogData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataTitleBlog,
            this.dataGenre,
            this.dataAuthor});
            this.dataAdminBlogData.DataSource = this.blogBindingSource;
            this.dataAdminBlogData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAdminBlogData.Location = new System.Drawing.Point(48, 30);
            this.dataAdminBlogData.Name = "dataAdminBlogData";
            this.dataAdminBlogData.RowHeadersVisible = false;
            this.dataAdminBlogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAdminBlogData.ShowCellToolTips = false;
            this.dataAdminBlogData.ShowEditingIcon = false;
            this.dataAdminBlogData.Size = new System.Drawing.Size(665, 300);
            this.dataAdminBlogData.TabIndex = 1;
            this.dataAdminBlogData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAdminBlogData_CellContentClick);
            this.dataAdminBlogData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAdminBlogData_CellDoubleClick);
            // 
            // dataTitleBlog
            // 
            this.dataTitleBlog.DataPropertyName = "title";
            this.dataTitleBlog.HeaderText = "Title";
            this.dataTitleBlog.MinimumWidth = 265;
            this.dataTitleBlog.Name = "dataTitleBlog";
            this.dataTitleBlog.Width = 265;
            // 
            // dataGenre
            // 
            this.dataGenre.DataPropertyName = "genre";
            this.dataGenre.HeaderText = "Genre";
            this.dataGenre.MinimumWidth = 200;
            this.dataGenre.Name = "dataGenre";
            this.dataGenre.Width = 200;
            // 
            // dataAuthor
            // 
            this.dataAuthor.DataPropertyName = "author";
            this.dataAuthor.HeaderText = "Author";
            this.dataAuthor.MinimumWidth = 200;
            this.dataAuthor.Name = "dataAuthor";
            this.dataAuthor.Width = 200;
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(Niche_Blog.server.Blog);
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
            this.tabreset_code.Location = new System.Drawing.Point(4, 22);
            this.tabreset_code.Name = "tabreset_code";
            this.tabreset_code.Padding = new System.Windows.Forms.Padding(3);
            this.tabreset_code.Size = new System.Drawing.Size(740, 407);
            this.tabreset_code.TabIndex = 2;
            this.tabreset_code.Text = "Reset Code";
            this.tabreset_code.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Admin ID";
            // 
            // txtAdmin
            // 
            this.txtAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdmin.ForeColor = System.Drawing.Color.Indigo;
            this.txtAdmin.Location = new System.Drawing.Point(353, 101);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(163, 22);
            this.txtAdmin.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(405, 255);
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
            this.txtNCPass.Location = new System.Drawing.Point(353, 213);
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
            this.txtNewCode.Location = new System.Drawing.Point(353, 174);
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
            this.txtOldPwd.Location = new System.Drawing.Point(353, 140);
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
            this.label4.Location = new System.Drawing.Point(191, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Confirm Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(188, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "New Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(185, 143);
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
            this.tabadd_blog.Controls.Add(this.txtDetails);
            this.tabadd_blog.Controls.Add(this.label7);
            this.tabadd_blog.Controls.Add(this.label6);
            this.tabadd_blog.Controls.Add(this.txtTitle);
            this.tabadd_blog.Controls.Add(this.txtType);
            this.tabadd_blog.Controls.Add(this.cmdAdd);
            this.tabadd_blog.ForeColor = System.Drawing.Color.Indigo;
            this.tabadd_blog.Location = new System.Drawing.Point(4, 22);
            this.tabadd_blog.Name = "tabadd_blog";
            this.tabadd_blog.Padding = new System.Windows.Forms.Padding(3);
            this.tabadd_blog.Size = new System.Drawing.Size(740, 407);
            this.tabadd_blog.TabIndex = 3;
            this.tabadd_blog.Text = "Add Blog";
            this.tabadd_blog.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.SeaShell;
            this.txtDetails.Location = new System.Drawing.Point(28, 95);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(676, 258);
            this.txtDetails.TabIndex = 7;
            this.txtDetails.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blog Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.SeaShell;
            this.txtTitle.Location = new System.Drawing.Point(109, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(311, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.SeaShell;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Social Life",
            "Medicine",
            "Health & Fitness",
            "Business",
            "Food",
            "Studies",
            "Freelancing",
            "Media Blogs",
            "Current Affairs"});
            this.txtType.Location = new System.Drawing.Point(109, 53);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(195, 24);
            this.txtType.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.SeaShell;
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdd.Location = new System.Drawing.Point(600, 369);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(104, 27);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lnkAdminLogout
            // 
            this.lnkAdminLogout.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkAdminLogout.AutoSize = true;
            this.lnkAdminLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnkAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAdminLogout.ForeColor = System.Drawing.Color.GhostWhite;
            this.lnkAdminLogout.LinkColor = System.Drawing.Color.SeaShell;
            this.lnkAdminLogout.Location = new System.Drawing.Point(608, 57);
            this.lnkAdminLogout.Name = "lnkAdminLogout";
            this.lnkAdminLogout.Size = new System.Drawing.Size(84, 25);
            this.lnkAdminLogout.TabIndex = 53;
            this.lnkAdminLogout.TabStop = true;
            this.lnkAdminLogout.Text = "Logout";
            this.lnkAdminLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdminLogout_LinkClicked);
            // 
            // ResetAdmin
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.lnkAdminLogout);
            this.Controls.Add(this.tabUserData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ResetAdmin";
            this.Load += new System.EventHandler(this.ResetAdmin_Load);
            this.tabUserData.ResumeLayout(false);
            this.tabuser_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabblog_record.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminBlogData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            this.tabreset_code.ResumeLayout(false);
            this.tabreset_code.PerformLayout();
            this.tabadd_blog.ResumeLayout(false);
            this.tabadd_blog.PerformLayout();
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
                    txtAdmin.Text = "";
                    txtNCPass.Text = "";
                    txtNewCode.Text = "";
                    txtOldPwd.Text = "";
                }
                else
                {
                    MessageBox.Show("Code does not match.");
                    txtNCPass.Text = "";
                    txtNewCode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid ID or Code or Both!");
                txtAdmin.Text = "";
                txtNCPass.Text = "";
                txtNewCode.Text = "";
                txtOldPwd.Text = "";
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

        private void lnkAdminLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin A = new Admin();
            A.Show();
        }
        List<server.Blog> list;
        private void ResetAdmin_Load(object sender, EventArgs e)
        {
            dataAdminUserData.AutoGenerateColumns = false;
            dataAdminBlogData.AutoGenerateColumns = false;

            //User Data Display
            server.Service1 server = new server.Service1();
            List<server.User> list1 = server.GetUser().ToList<server.User>();
            BindingSource b = new BindingSource();
            b.DataSource = list1;
            dataAdminUserData.DataSource = b;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataAdminUserData.SelectedRows)
            {
                Int32 ind = item.Index;
                server.Service1 server = new server.Service1();
                server.Delete(ind,true);
                dataAdminUserData.Rows.RemoveAt(item.Index);
            }            
        }

        private void cmdDeleteBlog_Click(object sender, EventArgs e)
        {

        }

        private void dataAdminBlogData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void tabuser_data_Click(object sender, EventArgs e)
        {
            dataAdminUserData.AutoGenerateColumns = false;
            //User Data Display
            server.Service1 server = new server.Service1();
            List<server.User> list1 = server.GetUser().ToList<server.User>();
            BindingSource b = new BindingSource();
            b.DataSource = list1;
            dataAdminUserData.DataSource = b;
        }

        private void tabblog_record_Click(object sender, EventArgs e)
        {
            dataAdminBlogData.AutoGenerateColumns = false;
            //Blog Record Gird Display
            server.Service1 ser = new server.Service1();
            List<server.Blog> list = ser.getBlog().ToList<server.Blog>();
            BindingSource a = new BindingSource();
            a.DataSource = list;
            dataAdminBlogData.DataSource = a;

        }

        private void dataAdminBlogData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
