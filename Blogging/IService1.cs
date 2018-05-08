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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //User 
        [OperationContract]
        string username();
        [OperationContract]
        string password();
        [OperationContract]
        string cpassword();
        [OperationContract]
        string gender();
        [OperationContract]
        string secretQuestion();
        [OperationContract]
        string answer();
        [OperationContract]
        Image img();
        [OperationContract]
        List<Interest> userGenre();

        //UserDL
        [OperationContract]
        bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder, Interest[] intrst);
        [OperationContract]
        bool Logout_U();
        [OperationContract]
        bool SetImage(string user, System.Drawing.Image imag);
        [OperationContract]
        bool Login(string user, string pwd);
        [OperationContract]
        bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans);
        [OperationContract]
        void Delete(Int32 index);
        [OperationContract]
        List<Interest> getGenre(string usernme);
        [OperationContract]
        List<User> GetUser();
        //[OperationContract]
        //Image getImage(string user);

        //Blog
        [OperationContract]
        string title();
        [OperationContract]
        string genre();
        [OperationContract]
        string text();
        [OperationContract]
        string author();
        [OperationContract]
        bool edit();

        //InterestDL
        List<Interest> GetIntr();

        //BlogDL
        [OperationContract]
        bool UploadBlog(string name, string type, string writing, string writer);
        [OperationContract]
        void EditBlog(string titl, string write, string req);
        [OperationContract]
        Blog ReadBlog(string name);
        [OperationContract]
        void Deleteblog(Int32 index);
        [OperationContract]
        List<Blog> User_Blog(string writer);
        [OperationContract]
        List<Blog> UserInterestBlog(string user);
        [OperationContract]
        List<Blog> getBlog();

        //Admin
        [OperationContract]
        string securityCode();
        [OperationContract]
        string name();
        [OperationContract]
        bool Access(string nme, string code);
        [OperationContract]
        bool Reset(string nme, string code, string ncode, string con_code);
        [OperationContract]
        bool Logout_A();
        [OperationContract]
        Admin get_instance();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
