using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
        public bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder)
        {
            UserDL D = new UserDL();
            bool a = D.AddUser(user, pwd, cpwd, s_ques, ans, gnder);
            return a;
        }
        public void Delete()
        {
            UserDL D = new UserDL();
            D.Delete();
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
        public void Logout()
        {
            UserDL D = new UserDL();
            D.Logout(); 
        }
        public bool UploadBlog(string name, string type, string writing)
        {
            BlogDL B = new BlogDL();
            bool l = B.UploadBlog(name, type, writing);
            return l;
        }
        //public void Delete() {
        //    BlogDL B = new BlogDL();
        //    B.Delete();
        //}

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


    }
}
