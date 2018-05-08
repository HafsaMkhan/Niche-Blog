using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Blogging
{
    [DataContract]
    public class BlogDL
    {
        [DataMember]
        public static List<Blog> LL = new List<Blog>();

        public bool UploadBlog(string name, string type, string writing, string writer)
        {
            //Interest intr = type;
            bool valid = false;
            int flag = 0;
            foreach (Blog b in LL)
            {
                if (b.title.ToLower() == name.ToLower())
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Blog chuss = new Blog();
                chuss.title = name;
                chuss.genre = type;
                chuss.text = writing;
                chuss.author = writer;
                LL.Add(chuss);
                valid = true;
            }
            return valid;
        }

        public void Deleteblog(Int32 index)
        {
            
        }

        public bool EditBlog(string titl, string write, string req)
        {
            bool edited = false;

            return edited;

        }

        public Blog ReadBlog(string name)
        {
            Blog ab = null;

            return ab;
        }

        public List<Blog> UserInterestBlog(string user)
        {
            List<Blog> Y = new List<Blog>();
            
            return Y;
        }

        public List<Blog> User_Blog(string writer)
        {
            List<Blog> y = new List<Blog>();
            foreach (Blog b in LL)
            {
                if (b.author.ToLower() == writer.ToLower())
                {
                    y.Add(b);
                }
            }
            return y;
        }

        public List<Blog> getBlog()
        {
            return LL;
        }

    }
}