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

        private void cmdResgister_Click(object sender, EventArgs e)
        {
            server.Interest[] arr = new server.Interest[checkedListBox1.CheckedItems.Count + 1];
            int j = 0;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    server.Interest interest = new server.Interest();
                    interest.type = checkedListBox1.Items[i].ToString();

                    arr[j] = interest;
                    j++;
                }
            }

            bool Validate;
            bool valid;
            
            if (txtPasswordR.TextLength < 6)
            {
                MessageBox.Show("Password should be at least 6 characters.");
            }
            else if (txtPasswordR.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match!");
                txtPasswordR.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {
                server.Service1 server = new server.Service1();
                server.AddUser(txtUsernameR.Text, txtPasswordR.Text, txtConfirmPassword.Text, txtSecretQuestion.Text, txtAnswer.Text, txtgender.Text, arr, out Validate, out valid);
                if (Validate == true & valid == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        MessageBox.Show("Congratulations! You registered successfully.");
                        txtUsernameR.Text = "";
                        txtPasswordR.Text = "";
                        txtConfirmPassword.Text = "";
                        txtSecretQuestion.Text = "";
                        txtAnswer.Text = "";
                        foreach (int i in checkedListBox1.CheckedIndices)
                        {
                            checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                        }
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
                    MessageBox.Show("Invalid user");
                    checkBox1.Checked = false;
                    txtPasswordR.Text = "";
                    txtConfirmPassword.Text = "";
                }
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            bool is_valid;
            bool validate;
            server.Service1 server = new server.Service1();
            server.Login(txtUsername.Text, txtPassword.Text, out is_valid, out validate);
            if (is_valid == true & validate == true)
            {
                this.Hide();
                MyUtility.loginUserName = txtUsername.Text.ToUpper();
                UserPortal up = new UserPortal();
                up.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password.");
                txtPassword.Text = "";

            }
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgetUserPass fp = new forgetUserPass();
            fp.Show();
        }

        private void cmdMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mp = new Main();
            mp.Show();
        }

        private void Registration_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
