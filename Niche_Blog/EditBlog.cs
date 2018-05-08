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
    public partial class EditBlog : Form
    {
        public EditBlog()
        {
            InitializeComponent();
        }

        private void EditBlog_Load(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            server.Blog b = server.ReadBlog(MyUtility.curr_Blog_Title);
            lblTitle.Text = b.title;
            lblType.Text = b.genre;
            txtDetail.Text = b.text;
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            bool v, b;
            server.Service1 server = new server.Service1();
            server.EditBlog(lblTitle.Text, txtDetail.Text, MyUtility.loginUserName,out v,out b);
            if(v==true & b == true)
            {
                MessageBox.Show("Blog edit successfully.");
                this.Hide();
            }
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtDetail.Font = fontDialog1.Font;
        }
    }
}
