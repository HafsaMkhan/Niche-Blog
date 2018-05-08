using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Blogging
{
    [DataContract]
    public class InterestDL
    {
        [DataMember]
        public static List<Interest> intr = new List<Interest>();

        public InterestDL()
        {
            Interest x = new Interest();
            x.type = "Social Life";
            intr.Add(x);
            x.type = "Medicine";
            intr.Add(x);
            x.type = "Health & Fitness";
            intr.Add(x);
            x.type = "Business";
            intr.Add(x);
            x.type = "Food";
            intr.Add(x);
            x.type = "Studies";
            intr.Add(x);
            x.type = "Freelancing";
            intr.Add(x);
            x.type = "Media Blogs";
            intr.Add(x);
            x.type = "Current Affairs";
            intr.Add(x);
        }
        
        public List<Interest> GetIntr()
        {
            return InterestDL.intr;
        }
    }
}