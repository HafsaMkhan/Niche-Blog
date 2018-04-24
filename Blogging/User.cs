using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace Blogging

{
    [DataContract]
    public class User
    {
       [DataMember]
        private string Username;
        [DataMember]
        private string Password;
        [DataMember]
        private string CPassword;
        [DataMember]
        private string Gender;
        [DataMember]
        private string SecretQuestion;
        [DataMember]
        private string Answer;
        [DataMember]
        private Image Img;
        [DataMember]
        private InterestDL UserGenre;

        public string username { get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }
        public string cpassword { get => CPassword; set => CPassword = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string secretQuestion { get => SecretQuestion; set => SecretQuestion = value; }
        public string answer { get => Answer; set => Answer = value; }
        public Image img { get => Img; set => Img = value; }
        public InterestDL userGenre { get => UserGenre; set => UserGenre = value; }
    }   
}