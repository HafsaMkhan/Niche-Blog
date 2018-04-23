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

        [OperationContract]
        bool AddUser(string user, string pwd, string cpwd, string s_ques, string ans, string gnder);
        [OperationContract]
        bool Logout_U();
        [OperationContract]
        string Show_Username();
        [OperationContract]
        bool SetImage(string user, Image imag);
        [OperationContract]
        bool Login(string user, string pwd);
        [OperationContract]
        bool ResetPassword(string user, string pwd, string cpwd, string s_ques, string ans);
        [OperationContract]
        void Delete();
        [OperationContract]

        //Blog
        bool UploadBlog(string name, string type, string writing);
        [OperationContract]
        void EditBlog(string titl, string write);
        [OperationContract]
        Blog ReadBlog(string name);
        
        //Admin
        [OperationContract]
        bool Access(string nme, string code);
        [OperationContract]
        bool Reset(string nme, string code, string ncode, string con_code);
        [OperationContract]
        bool Logout_A();
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
