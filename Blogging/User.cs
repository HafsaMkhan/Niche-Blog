using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging

{
    public class User
    {
       
        private string Username;
        private string Password;
        private string CPassword;
        private string Gender;
        private Interests Type;
        private string SecretQuestion;
        private string Answer;

        public string username { get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }
        public string cpassword { get => CPassword; set => CPassword = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string secretQuestion { get => SecretQuestion; set => SecretQuestion = value; }
        public string answer { get => Answer; set => Answer = value; }
        public Interests type { get => Type; set => Type = value; }
    }
        
    }
