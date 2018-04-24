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
    public partial class UserPortal : Form
    {
        public UserPortal()
        {
            InitializeComponent();
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

        private void ucProfile1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox.Image = img;
        }

        private void cmdimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            server.Service1 server = new server.Service1();
            server.userGenre();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPortal_Load(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            lblShowUser.Text = server.username();
            MyUtility.loginUserName = server.username();

            server.Service1 servers = new server.Service1();
            BindingSource a = new BindingSource();
            a.DataSource = servers.userGenre();
            dataGridView1.DataSource = a;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblShowUser_Click(object sender, EventArgs e)
        {

        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyUtility.loginUserName = "";
            this.Hide();
            Registration_Login rl = new Registration_Login();
            rl.Show();
        }
    }
}
