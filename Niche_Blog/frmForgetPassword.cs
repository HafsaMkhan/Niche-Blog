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
                    txtAnswer.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPasswordR.Text = "";
                    txtUsernameR.Text = "";
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                    txtConfirmPassword.Text = "";
                    txtPasswordR.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Incorrect information.");
                txtAnswer.Text = "";
                txtConfirmPassword.Text = "";
                txtPasswordR.Text = "";
                txtUsernameR.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserPortal up = new UserPortal();
            up.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            lblShowUsername.Text = MyUtility.loginUserName;
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordR_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MyUtility.loginUserDp = null;
            MyUtility.loginUserName = "";
            Registration_Login rl = new Registration_Login();
            rl.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UploadUserBlog ub = new UploadUserBlog();
            ub.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ReadUserBlog rb = new ReadUserBlog();
            rb.Show();
        }
    }
}
