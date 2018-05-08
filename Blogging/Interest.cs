using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Runtime.Serialization;

namespace Blogging
{
    [DataContract]
    public class Interest
    {
        private string Type;
        [DataMember]
        public string[] Multi_Interest = new string[100];
        [DataMember]
        public string type { get => Type; set => Type = value; }
    }
}