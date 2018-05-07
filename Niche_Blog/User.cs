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
        private string Username;
        private string Password;
        private string CPassword;
        private string Gender;
        private string SecretQuestion;
        private string Answer;
        private Image Img;
        private List<Interest> UserGenre = new List<Interest>();

        [DataMember]
        public string username { get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }
        public string cpassword { get => CPassword; set => CPassword = value; }
        [DataMember]
        public string gender { get => Gender; set => Gender = value; }
        [DataMember]
        public string secretQuestion { get => SecretQuestion; set => SecretQuestion = value; }
        [DataMember]
        public string answer { get => Answer; set => Answer = value; }
        [DataMember]
        public Image img { get => Img; set => Img = value; }
        [DataMember]
        public List<Interest> userGenre { get => UserGenre; set => UserGenre = value; }

    }
}