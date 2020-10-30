using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Created { get; private set; }
        public int Votes { get; private set; }

        public Post() { }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
            Votes = 0;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            if (Votes < 0)
                Votes--;
        }
    }
}
