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

        public bool Reset(string nme,string code,string ncode,string con_code) { }

        public bool Access(string nme, string code) { }

        public bool Logout_A() { }
    }

}