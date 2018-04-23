using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging
{
    public class Admin
    {
        private string SecurityCode;
        private string Name;
        public Admin()
        {
            Name = "admin@123";
            SecurityCode = "12345678";
        }

        public string securityCode { get => SecurityCode; set => SecurityCode = value; }
        public string name { get => Name; set => Name = value; }

        public bool Reset(string nme,string code,string ncode,string con_code)
        {
            bool valid = false;
            if (Name == "admin@123" & securityCode == code)
            {
                if (ncode == con_code)
                {
                    securityCode = ncode;
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }
            return valid;
        }

        public bool Access(string nme, string code)
        {
            bool valid = false;
            if(Name==nme & securityCode == code)
            {
                valid = true;
            }
            return valid;
        }

        public bool Logout_A()
        {
            bool close = false;


            return close;
        }
    }

}