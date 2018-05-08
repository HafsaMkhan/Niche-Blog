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
    public partial class ReadUserBlog : Form
    {
        public ReadUserBlog()
        {
            InitializeComponent();
        }

        private void lnkHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserPortal up = new UserPortal();
            up.Show();
        }

        private void lnkRead_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReadUserBlog rb = new ReadUserBlog();
            rb.Show();
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UploadUserBlog rb = new UploadUserBlog();
            rb.Show();
        }

        private void lnkLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MyUtility.loginUserName = "";
            MyUtility.loginUserDp = null;
            Registration_Login rl = new Registration_Login();
            rl.Show();
        }

        private void lnkResetPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
        }

        private void dataReadBlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<server.Blog> blog;
        private void ReadUserBlog_Load(object sender, EventArgs e)
        {
            dataReadBlog.AutoGenerateColumns = false;
            server.Service1 server = new server.Service1();
            blog = server.UserInterestBlog(MyUtility.loginUserName).ToList<server.Blog>();

            BindingSource b = new BindingSource();
            b.DataSource = blog;
            dataReadBlog.DataSource = b;
        }

        private void dataReadBlog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataReadBlog.AutoGenerateColumns = false;
            server.Blog blg = blog[e.RowIndex];
            MyUtility.curr_Blog_Title = blg.title;
            ViewBlogE vb = new ViewBlogE();
            vb.Show();
        }

        private void dataReadBlog_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
