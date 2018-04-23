using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Blogging
{
    public class UserDL
    {
        public static List<User> users = new List<User>();

        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder) { }
     
        public void Delete()
        {

        }

        public bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans) { }

        public bool Login(string user, string pwd) { }
        
        public bool SetImage(string user, Image imag)
        {
            bool is_set = false;
            foreach(User u in users)
            {
                if (u.username == user)
                {
                    Image img = imag;
                    is_set = true;
                }
            }
            return is_set;
        }

        public bool Logout_U()
        {
            bool s = false;
            // Session.Clear();
            //Session.RemoveAll();
            //Session.Abandon();

            //System.Web.Security.FormsAuthentication.SignOut();
            //Response.Redirect("Registration_Login.aspx");
            return s;
        }

    }
}


