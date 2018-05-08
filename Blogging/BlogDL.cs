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
            LL.RemoveAt(index);
        }

        public bool EditBlog(string titl, string write, string req)
        {
            bool edited = false;
            foreach (Blog b in BlogDL.LL)
            {
                if (b.title.ToLower() == titl.ToLower() & (b.author.ToLower() == req.ToLower() || b.author == "admin@123"))
                {
                    b.text = write;
                    edited = true;
                }
            }
            return edited;

        }

        public Blog ReadBlog(string name)
        {
            Blog ab = null;
            foreach(Blog b in BlogDL.LL)
            {
                if(b.title == name)
                {
                    return b;
                }
            }
            return ab;
        }

        public List<Blog> UserInterestBlog(string user)
        {
            List<Blog> Y = new List<Blog>();
            Interest gen = new Interest();
            foreach (User u in UserDL.users)
            {
                if (u.username.ToLower() == user.ToLower()) 
                {
                    foreach (Interest t in u.userGenre) 
                    {
                        foreach (Blog b in LL)
                        {
                            gen.type = b.genre;
                            if (t.type== gen.type)
                            {
                                Y.Add(b);
                            }
                        }
                    }
                }
            }
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