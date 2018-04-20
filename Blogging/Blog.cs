using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging
{
    public class Blog
    {
        private string Title;
        private string Genre;
        private string Text;
        //private DateTime Date;

        public string title { get => Title; set => Title = value; }
        public string genre { get => Genre; set => Genre = value; }
        public string text { get => Text; set => Text = value; }
        //public DateTime date { get => Date; set => Date = value; }
    }
}