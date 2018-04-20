using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging
{
    public class Admin
    {
        private int SecurityCode;
        private string Name;

        public int securityCode { get => SecurityCode; set => SecurityCode = value; }
        public string name { get => Name; set => Name = value; }
        public void Reset(int code)
        {
            

    }

}