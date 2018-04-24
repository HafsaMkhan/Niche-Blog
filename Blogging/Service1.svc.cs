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
        public InterestDL userGenre()
        {
            User U = new User();
            InterestDL s = U.userGenre;
            return s;
        }

        //UserDL
        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder, string[] intrst)
        {
            UserDL D = new UserDL();
            bool a = D.AddUser(user, pwd, cpwd, s_ques, ans, gnder, intrst);
            return a;
        }
        public void Delete()
        {
            UserDL D = new UserDL();
            D.Delete();
            BlogDL B = new BlogDL();
            B.Delete();

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
        public bool SetImage(string user, Image imag)
        {
            UserDL U = new UserDL();
            bool s = U.SetImage(user, imag);
            return s;
        }
        public bool Logout_U()
        {
            UserDL D = new UserDL();
            bool m = D.Logout_U();
            return m;
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

        //BlogDL
        public bool UploadBlog(string name, string type, string writing)
        {
            BlogDL B = new BlogDL();
            bool l = B.UploadBlog(name, type, writing);
            return l;
        }
        public void EditBlog(string titl, string write)
        {
            BlogDL B = new BlogDL();
            B.EditBlog(titl, write);
        }
        public Blog ReadBlog(string name)
        {
            BlogDL B = new BlogDL();
            Blog bb = B.ReadBlog(name);
            return bb;
        }

        //Admin
        public string securityCode()
        {
            Admin A = new Admin();
            string v = A.securityCode;
            return v;
        }
        public string name()
        {
            Admin A = new Admin();
            string v = A.name;
            return v;
        }
        public bool Access(string nme, string code)
        {
            Admin A = new Admin();
            bool n = A.Access(nme, code);
            return n;
        }
        public bool Reset(string nme, string code, string ncode, string con_code)
        {
            bool n;
            Admin A = new Admin();
            n = A.Reset(nme, code, ncode, con_code);
            return n;
        }
        public bool Logout_A()
        {
            Admin D = new Admin();
            bool m = D.Logout_A();
            return m;
        }
    }
}
