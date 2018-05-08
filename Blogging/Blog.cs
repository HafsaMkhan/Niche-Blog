using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Blogging
{
    [DataContract]
    public class Blog
    {
        private string Title;
        private string Genre;
        private string Text;
        private string Author;
        //private Boolean Isapproved;
        //private DateTime Date;
        private Boolean Edit;

        [DataMember]
        public string title { get => Title; set => Title = value; }
        [DataMember]
        public string genre { get => Genre; set => Genre = value; }
        [DataMember]
        public string text { get => Text; set => Text = value; }
        [DataMember]
        public string author { get => Author; set => Author = value; }
        [DataMember]
        public bool edit { get => Edit; set => Edit = value; }

        //public bool isapproved { get => Isapproved; set => Isapproved = value; }



        //public DateTime date { get => Date; set => Date = value; }
    }
}