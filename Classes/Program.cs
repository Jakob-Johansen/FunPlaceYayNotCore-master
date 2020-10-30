using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProgram();
        }

        static void MainProgram()
        {
            string userInputAsText = string.Empty;
            int userInputAsNumber;

            int ballQuantity;

            Console.WriteLine("Welcome! In this game we gonna play with some balls! Yay!\n");

            Console.WriteLine("Vi starter med at lave en bold.\n");

            while (!Int32.TryParse(userInputAsText, out userInputAsNumber) || userInputAsNumber == 0)
            {
                Console.Write("Hvor mange bolde vil du lave?: ");
                userInputAsText = Console.ReadLine().Trim();

                if (Int32.TryParse(userInputAsText, out userInputAsNumber))
                {
                    if (userInputAsNumber == 0)
                    {
                        Console.WriteLine("Du kan ikke vælge 0.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Du skal skrive et tal.\n");
                }
            }

            ballQuantity = userInputAsNumber;

            // Hjælp fra Svend

            List<BallTest> ballList = new List<BallTest>();
            Random random = new Random();
            for (int i = 0; i < ballQuantity; i++)
            {
                BallTest ball = new BallTest(random.Next(1, 99), 5);
                ballList.Add(ball);
                Thread.Sleep(1);
            }

            Console.ReadLine();

            //ballList[0].Pop();


        }
    }
}
