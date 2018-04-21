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
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        private static frmForgetPassword form;

        public static frmForgetPassword get_instance()
        {
            if (form == null)
            {
                form = new frmForgetPassword();
                return form;
            }
            else
                return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_valid;
            bool Validate;
            server.Service1 server = new server.Service1();
            server.ResetPassword(txtUsernameR.Text, txtPasswordR.Text, txtConfirmPassword.Text, SecretQuestion.Text, txtAnswer.Text, out Validate, out is_valid);
            if(is_valid==true & Validate == true)
            {
                if (txtPasswordR.Text == txtConfirmPassword.Text)
                {
                    MessageBox.Show("Succesfully! Password Reset.");
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect information.");
            }
        }
    }
}
