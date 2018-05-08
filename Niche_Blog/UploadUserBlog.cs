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
    public partial class UploadUserBlog : Form
    {
        public UploadUserBlog()
        {
            InitializeComponent();
        }

        List<server.Blog> lst;
        


        private void UploadUserBlog_Load(object sender, EventArgs e)
        {
            lblShowUser.Text = MyUtility.loginUserName;

            server.Service1 ser = new server.Service1();
            lst = ser.User_Blog(MyUtility.loginUserName).ToList<server.Blog>();

            BindingSource a = new BindingSource();
            a.DataSource = lst;
            dataReadBlog.DataSource = a;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MyUtility.loginUserName = "";
            MyUtility.loginUserDp = null;
            Registration_Login rl = new Registration_Login();
            rl.Show();
        }

        private void lnkResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
            
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserPortal up = new UserPortal();
            up.Show();
        }

        private void lnkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReadUserBlog ru = new ReadUserBlog();
            ru.Show();
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.Show();
        }
       
        private void dataReadBlog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataReadBlog.AutoGenerateColumns = false;

            server.Blog blg = lst[e.RowIndex];
            MyUtility.curr_Blog_Title = blg.title;
            ViewBlogE rb = new ViewBlogE();
            rb.Show();
        }

        private void cmdEditBlog_Click(object sender, EventArgs e)
        {
            //dataReadBlog.MultiSelect = false;
            //foreach (DataGridViewRow item in this.dataReadBlog.SelectedRows)
            //{
            //    Int32 ind = item.Index;
            //    server.Service1 server = new server.Service1();
                
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isfound=false;
            int i = 0;
            server.Service1 ser = new server.Service1();
            foreach(DataGridViewRow row in dataReadBlog.Rows)
            {
                if(Convert.ToBoolean(row.Cells[3].Value))
                {
                    server.Blog s = lst[row.Index];
                    isfound = true;
                    MyUtility.curr_Blog_Title = s.title;
                    UploadBlog ub = new UploadBlog();
                    ub.Show();
                }
            }
            if (isfound == false)
            {
                MessageBox.Show("Please select any value");
            }
        }

        private void dataReadBlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
