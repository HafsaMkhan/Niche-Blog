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
    public partial class ViewBlogE : Form
    {
        public ViewBlogE()
        {
            InitializeComponent();
        }

        private void ViewBlog_Load(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            server.Blog B = server.ReadBlog(MyUtility.curr_Blog_Title);
            lblTitle.Text = B.title;
            lblGenre.Text = B.genre;
            lblDetails.Text = B.text;
            MyUtility.curr_Blog_Title = "";
        }
    }
}
