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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin A = new Admin();
            A.Show();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Login U = new Registration_Login();
            U.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Login U = new Registration_Login();
            U.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin A = new Admin();
            A.Show();
        }
    }
}
