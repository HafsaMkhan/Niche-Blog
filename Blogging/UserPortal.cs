using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Niche_Blog
{
    public partial class UserPortal : Form
    {
        public UserPortal()
        {
            InitializeComponent();
            server.Service1 server = new server.Service1();
            label2.Text = server.username();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            label2.Text = server.username();
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserPortal up = new UserPortal();
            up.Show();
        }

        private void lnkResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           // bool val, found;
            Image imge = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox.Image = imge;
            MyUtility.loginUserDp = imge;
            
            server.Service1 server = new server.Service1();
            //server.SetImage(MyUtility.loginUserName, pictureBox.Image, out val, out found);
        }
        
        private void cmdimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void UserPortal_Load(object sender, EventArgs e)
        {
            lblShowUser.Text = MyUtility.loginUserName;

            server.Service1 server = new server.Service1();
            List<server.Interest> list = server.getGenre(MyUtility.loginUserName).ToList<server.Interest>();
            BindingSource a = new BindingSource();
            a.DataSource = list;
            dataGridView1.DataSource = a;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyUtility.loginUserName = "";
            MyUtility.loginUserDp = null;
            this.Hide();
            Registration_Login rl = new Registration_Login();
            rl.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadBlog ub = new UploadBlog();
            ub.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadUserBlog rb = new ReadUserBlog();
            rb.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
