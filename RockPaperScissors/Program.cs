using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til sten saks papir, bedst ud af 3\n");

            string[] pick = new string[3] { "Sten", "Saks", "Papir"};

            Random random = new Random();

            int ply1;
            int ply2;

            int ply1Points = 0;
            int ply2Points = 0;

            bool never = false;

            while (never == false)
            {
                ply1 = random.Next(0, 3);
                ply2 = random.Next(0, 3);

                Console.WriteLine("\nComputer1: " + pick[ply1]);
                Console.WriteLine("Computer2: " + pick[ply2]);

                if (ply1 == ply2)
                {
                    Console.WriteLine("Det er en ommer");
                }
                else if (ply1 > ply2)
                {
                    ply1Points++;
                    Console.WriteLine("Computer1 Vinder et point!");
                }
                else if (ply1 < ply2)
                {
                    ply2Points++;
                    Console.WriteLine("Computer2 vinder et point!");
                }
                else
                {
                    Console.WriteLine("Der skete en fejl.");
                }

                Console.WriteLine("\nComputer1 points: " + ply1Points);
                Console.WriteLine("Computer2 points: " + ply2Points);
                Thread.Sleep(1000);
            }

            Console.ReadLine();

        }

    }
}
