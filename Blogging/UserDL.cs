using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.Runtime.Serialization;

namespace Blogging
{
    [DataContract]
    public class UserDL
    {
        [DataMember]
        public static List<User> users = new List<User>();

        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder, Interest[] intrst)
        {
            bool is_valid = false;
            int flag = 0;
            foreach(User a in UserDL.users)
            {
                if (a.username.ToLower() == user.ToLower())
                {
                    flag= 1;
                }
            }
            if (pwd != cpwd)
            {
                is_valid = false;
            }
            else if (flag==0)
            {
                User u = new User();
                u.username = user;
                u.password = pwd;
                u.cpassword = cpwd;
                u.secretQuestion = s_ques;
                u.answer = ans;
                u.gender = gnder;
                for (int i = 0; i < intrst.Length - 1; i++)
                {
                  u.userGenre.Add(intrst[i]);
                }
                users.Add(u);        
                is_valid = true;
            }
            return is_valid;
    }

        public List<Interest> getGenre(string usernme)
        {
            List<Interest> k = null;
            foreach(User u in users)
            {
                if (u.username.ToLower() == usernme.ToLower())
                {
                    return u.userGenre;
                }
            }
            return k;
        }

        public void Delete(Int32 index)
        {
            users.RemoveAt(index);
        }

        public bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans)
        {
            bool isvalid=false;
            foreach (User u in UserDL.users)
            {
                if (u.username.ToLower() == user.ToLower())
                {
                    if (u.secretQuestion == s_ques & u.answer == ans)
                    {
                        if (pwd == cpwd)
                        {
                            u.password = pwd;
                            u.cpassword = cpwd;
                            isvalid= true;
                        }
                    }
                    else
                    {
                        if (u.secretQuestion != s_ques & u.answer == ans)
                        {
                            isvalid= false;

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
            foreach(User u in UserDL.users)
            {
                if(u.username.ToLower() == user.ToLower() & u.password == pwd)
                {
                    valid = true;
                }
            }
                return valid;
        }
        
        public bool SetImage(string user, System.Drawing.Image imag)
        {
            bool is_set = false;
            foreach(User u in users)
            {
                if (u.username.ToLower() == user.ToLower())
                {
                    u.img = imag;
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

        public List<User> GetUser()
        {
            return users;
        }

        //public Image getImage(string user)
        //{
        //    Image pic = null;
        //    foreach(User u in users)
        //    {
        //        if (u.username == user)
        //        {
        //            return u.img;
        //        }
        //    }
        //    return pic;
        //}

    }
}


