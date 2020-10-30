using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores;
            scores = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] scoresCopy = new int[scores.Length];

            for (int i = 0; i < scores.Length; i++)
            {
                scoresCopy[i] += scores[i];
                Console.WriteLine(scoresCopy[i]);
            }

            Console.ReadKey();

        }
    }
}
