using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Hello World!", "I'm testing");

            var random = new Random();

            for (int i = 0; i < 20; i++)
            {
                if (random.Next(0,2) == 0)
                {
                    post.DownVote();
                }
                else
                {
                    post.UpVote();
                }
            }

            Console.WriteLine("Title: " + post.Title + "\nDescription: " + post.Description + "\nCreated: " + post.Created + "\nVotes: " + post.Votes);
        }
    }
}
