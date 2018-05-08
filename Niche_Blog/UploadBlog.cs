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
    public partial class UploadBlog : Form
    {
        public UploadBlog()
        {
            InitializeComponent();
        }

        private void UploadBlog_Load(object sender, EventArgs e)
        {
            lblShowUser.Text = MyUtility.loginUserName;
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            txtDetail.Font = fontDialog.Font;
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            bool vall, value;
            server.Service1 serv = new server.Service1();
            serv.UploadBlog(txtTitle.Text, txtGenre.Text, txtDetail.Text, MyUtility.loginUserName, out vall, out value);
            if (vall == true & value == true)
            {
                MessageBox.Show("Blog uploaded successfully!");
                this.Hide();
                UserPortal up = new UserPortal();
                up.Show();
            }
            else
            {
                MessageBox.Show("Retry! Connection problem.");
            }
        }

        private void lnkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReadUserBlog rb = new ReadUserBlog();
            rb.Show();
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserPortal up = new UserPortal();
            up.Show();
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void lnkResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyUtility.loginUserName = "";
            MyUtility.loginUserDp = null;
            Registration_Login rl = new Registration_Login();
            this.Hide();
            rl.Show();
        }
    }
}
