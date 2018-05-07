using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging
{
    public class Admin
    {
        private Admin()
        {
            Name = "admin@123";
        }
        public static Admin admin_inst;
        public static bool admin_check = false;

        public static Admin get_instance()
        {
            if (admin_check == false)
            {
                admin_check = true;
                admin_inst = new Admin();
                return admin_inst;
            }
            else
                return admin_inst;
        }


        private string SecurityCode;
        private string Name = "admin@123";
        private string defaultcode = "123";
        private static int pass = 0;

        public string securityCode { get => SecurityCode; set => SecurityCode = value; }
        public string name { get => Name; set => Name = value; }
        public string Defaultcode { get => defaultcode; set => defaultcode = value; }
        public static int Pass { get => pass; set => pass = value; }

        public bool Reset(string nme, string code, string ncode, string con_code)
        {
            bool valid = false;
            if (Name == nme & SecurityCode == code & pass == 1)
            {
                if (ncode == con_code)
                {
                    SecurityCode = ncode;
                    valid = true;
                }
            }
            else if (Name == nme & defaultcode == code & pass == 0)
            {
                if (ncode == con_code)
                {
                    SecurityCode = ncode;
                    pass = 1;
                    valid = true;
                }
            }
            return valid;
        }

        public bool Access(string nme, string code)
        {
            bool valid = false;
            if (Name == nme & defaultcode == code & pass == 0)
            {
                valid = true;
            }
            else if (Name == nme & SecurityCode == code & pass == 1)
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