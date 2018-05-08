using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;

namespace Blogging
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        //User
        public string username()
        {
            User U = new User();
            string s = U.username;
            return s;
        }
        public string password()
        {
            User U = new User();
            string s = U.password;
            return s;
        }
        public string cpassword()
        {
            User U = new User();
            string s = U.password;
            return s;
        }
        public string gender()
        {
            User U = new User();
            string s = U.gender;
            return s;
        }
        public string secretQuestion()
        {
            User U = new User();
            string s = U.secretQuestion;
            return s;
        }
        public string answer()
        {
            User U = new User();
            string s = U.answer;
            return s;
        }
        public Image img()
        {
            User U = new User();
            Image s = U.img;
            return s;
        }
        public List<Interest> userGenre()
        {
            User U = new User();
            List<Interest> s = U.userGenre;
            return s;
        }

        //UserDL
        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder, Interest[] intrst)
        {
            UserDL D = new UserDL();
            bool a = D.AddUser(user, pwd, cpwd, s_ques, ans, gnder, intrst);
            return a;
        }
        public void Delete(Int32 index)
        {
            UserDL D = new UserDL();
            D.Delete(index);
        }
        public bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans)
        {
            UserDL D = new UserDL();
            bool a = D.ResetPassword(user, pwd, cpwd, s_ques, ans);
            return a;
        }
        public bool Login(string user, string pwd)
        {
            UserDL D = new UserDL();
            bool a = D.Login(user, pwd);
            return a;
        }
        public bool SetImage(string user, System.Drawing.Image imag)
        {
            UserDL U = new UserDL();
            bool s = U.SetImage(user, imag);
            return s;
        }
        public List<Interest> getGenre(string usernme)
        {
            UserDL U = new UserDL();
            List<Interest> s = U.getGenre(usernme);
            return s;
        }
        //public Image getImage(string user)
        //{
        //    UserDL U = new UserDL();
        //    Image s = U.getImage(user);
        //    return s;
        //}
        public bool Logout_U()
        {
            UserDL D = new UserDL();
            bool m = D.Logout_U();
            return m;
        }
        public List<User> GetUser()
        {
            UserDL U = new UserDL();
            List<User> k = U.GetUser();
            return k;
        }

        //Blog
        public string title()
        {
            Blog B = new Blog();
            string m = B.title;
            return m;
        }
        public string genre()
        {
            Blog B = new Blog();
            string m = B.genre;
            return m;
        }
        public string text()
        {
            Blog B = new Blog();
            string m = B.text;
            return m;
        }
        public string author()
        {
            Blog B = new Blog();
            string m = B.author;
            return m;
        }
        public bool edit()
        {
            Blog B = new Blog();
            bool m = B.edit;
            return m;
        }

        //InterestDL
        public List<Interest> GetIntr()
        {
            InterestDL I = new InterestDL();
            List<Interest> s = I.GetIntr();
            return s;
        }

        //BlogDL
        public bool UploadBlog(string name, string type, string writing, string writer)
        {
            BlogDL B = new BlogDL();
            bool l = B.UploadBlog(name, type, writing, writer);
            return l;
        }
        public void EditBlog(string titl, string write, string req)
        {
            BlogDL B = new BlogDL();
            B.EditBlog(titl, write, req);
        }
        public Blog ReadBlog(string name)
        {
            BlogDL B = new BlogDL();
            Blog bb = B.ReadBlog(name);
            return bb;
        }
        public void Deleteblog(Int32 index)
        {
            BlogDL B = new BlogDL();
            B.Deleteblog(index);
        }
        public List<Blog> User_Blog(string writer)
        {
            BlogDL B = new BlogDL();
            List<Blog> k = B.User_Blog(writer);
            return k;
        }
        public List<Blog> UserInterestBlog(string user)
        {
            BlogDL B = new BlogDL();
            List<Blog> s = B.UserInterestBlog(user);
            return s;
        }
        public List<Blog> getBlog()
        {
            BlogDL B = new BlogDL();
            List<Blog> k = B.getBlog();
            return k;
        }

        //Admin
        public Admin get_instance()
        {
            return Admin.get_instance();
        }

        public string securityCode()
        {
            Admin A = Admin.get_instance();
            string v = A.securityCode;
            return v;
        }
        public string name()
        {
            Admin A = Admin.get_instance();
            string v = A.name;
            return v;
        }

        //AdminDL


        public bool Access(string nme, string code)
        {
            Admin A = Admin.get_instance();
            bool n = A.Access(nme, code);
            return n;
        }
        public bool Reset(string nme, string code, string ncode, string con_code)
        {
            bool n;
            Admin A = Admin.get_instance();
            n = A.Reset(nme, code, ncode, con_code);
            return n;
        }
        public bool Logout_A()
        {
            Admin D = Admin.get_instance();
            bool m = D.Logout_A();
            return m;
        }
    }
}
