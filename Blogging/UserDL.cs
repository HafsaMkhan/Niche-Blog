using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging
{
    public class UserDL
    {
        public static List<User> users = new List<User>();

        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder)
        {
            bool is_valid = false;
            foreach (User a in UserDL.users)
            {
                if (a.username == user)
                {
                    is_valid = false;
                }
            }
            if (pwd != cpwd)
            {

            }
            else
            {
                User u = new User();
                u.username = user;
                u.password = pwd;
                u.cpassword = cpwd;
                u.secretQuestion = s_ques;
                u.answer = ans;
                u.gender = gnder;
                users.Add(u);
                is_valid = true;
            }
            return is_valid;
        }

        public void Delete()
        {

        }
        public bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans)
        {
            bool isvalid = false;
            foreach (User u in UserDL.users)
            {
                if (u.username == user)
                {
                    if (u.secretQuestion == s_ques & u.answer == ans)
                    {
                        if (pwd == cpwd)
                        {
                            u.password = pwd;
                            u.cpassword = cpwd;
                            isvalid = true;
                        }
                    }
                    else
                    {
                        if (u.secretQuestion != s_ques & u.answer == ans)
                        {
                            isvalid = false;

                        }
                        else if (pwd != cpwd)
                        {
                            isvalid = false;
                        }
                    }
                }
            }
            return isvalid;
        }
        public bool Login(string user, string pwd)
        {
            bool valid = false;
            foreach (User u in UserDL.users)
            {
                if (u.username == user & u.password == pwd)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public void Logout()
        {        }

    }
}


