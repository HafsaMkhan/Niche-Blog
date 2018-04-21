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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private static Admin Register_form;

        public static Admin get_instance()
        {
            if (Register_form == null)
            {
                Register_form = new Admin();
                return Register_form;
            }
            else
                return Register_form;
        }

        private void cmdAccess_Click(object sender, EventArgs e)
        {
            bool valid=true;
            bool is_valid;
            bool validate;
            server.Service1 server = new server.Service1();
            int i = int.Parse(txtAccess_Code.Text);

            server.Access(txtAdmin_Titlle.Text, i, valid, out is_valid,out validate);
            if(validate==true & is_valid == true)
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid information");
            }
        }

        private void cmdMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main A = new Main();
            A.Show();
        }

        private void txtAccess_Code_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(txtAccess_Code.Text);
        }
    }
}
