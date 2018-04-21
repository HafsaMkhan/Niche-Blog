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
    public partial class Registration_Login : Form
    {
        public Registration_Login()
        {
            InitializeComponent();
        }
        private static Registration_Login Register_form;

        public static Registration_Login get_instance()
        {
            if (Register_form == null)
            {
                Register_form = new Registration_Login();
                return Register_form;
            }
            else
                return Register_form;
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgetPassword l = frmForgetPassword.get_instance();
            Registration_Login.get_instance().Hide();
            l.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdResgister_Click(object sender, EventArgs e)
        {
            bool Validate;
            bool valid ;

            server.Service1 server = new server.Service1();
            server.AddUser( txtUsernameR.Text, txtPasswordR.Text, txtConfirmPassword.Text, txtSecretQuestion.Text, txtAnswer.Text, txtgender.Text, out Validate, out valid);
            if(Validate == true )
            {
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Congragulations! You registered successfully.");
                    txtUsernameR.Text = "";
                    txtPasswordR.Text = "";
                    txtConfirmPassword.Text = "";
                    txtSecretQuestion.Text = "";
                    txtAnswer.Text = "";
                    Interests.Text = "";
                    txtgender.Text = "";
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("You need to agree with terms and condition in order to proceed");
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
                checkBox1.Checked = false;
                txtPasswordR.Text = "";
                txtConfirmPassword.Text = "";
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            bool is_valid;
            bool validate;
            server.Service1 server = new server.Service1();
            server.Login(txtUsername.Text, txtPassword.Text, out is_valid, out validate);
            if(is_valid == true)
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Invalid username and password.");
            }
        }

        public void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtUsernameR_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtPasswordR_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        public void InterestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
