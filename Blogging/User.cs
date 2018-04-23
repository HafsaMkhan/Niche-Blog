using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Blogging

{
    public class User
    {
       
        private string Username;
        private string Password;
        private string CPassword;
        private string Gender;
        private string SecretQuestion;
        private string Answer;
        private Image Img;
        //private string[] Genre;

        public string username { get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }
        public string cpassword { get => CPassword; set => CPassword = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string secretQuestion { get => SecretQuestion; set => SecretQuestion = value; }
        public string answer { get => Answer; set => Answer = value; }
        public Image img { get => Img; set => Img = value; }

        //  public string[] genre { get => Genre; set => Genre = value; }

        public string Show_Username()
        {
            return username;
        }
    }
        
    }
