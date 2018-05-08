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
    public partial class forgetUserPass : Form
    {
        public forgetUserPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_valid, Validate;
            server.Service1 server = new server.Service1();
            server.ResetPassword(txtUsernameR.Text, txtPasswordR.Text, txtConfirmPassword.Text, SecretQuestion.Text, txtAnswer.Text, out Validate, out is_valid);
            if (is_valid == true & Validate == true)
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
    }

}
