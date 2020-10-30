using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            myProgram();
        }
        static void CountToTen(int count)
        {
            Console.WriteLine("\nJeg vil nu tælle til " + count + "\n");
            if (count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine(i);

                    // Laver delay så alt ikke bliver udskrevet på samme tid.
                    Thread.Sleep(30);
                }
            }

            Console.WriteLine("\nVi har lige talt til " + count + "! Yaaay!\n");
            Thread.Sleep(50);
        }

        static void myProgram()
        {
            string userinputAsText = "";
            int userInputAsNumber;

            Console.WriteLine("Tæl til 10 program Yaaaay!\n");

            while (!Int32.TryParse(userinputAsText, out userInputAsNumber))
            {
                Console.Write("Skriv et tal: ");
                userinputAsText = Console.ReadLine();
                if (!Int32.TryParse(userinputAsText, out userInputAsNumber))
                    Console.WriteLine("Du skrev ikke et tal prøv igen\n");
            }

            CountToTen(userInputAsNumber);

            while (userinputAsText != "y" && userinputAsText != "n")
            {
                Console.WriteLine("Vil du prøve igen? (y/n)");
                userinputAsText = Console.ReadLine().ToLower().Trim();
                if (userinputAsText != "y" && userinputAsText != "n")
                    Console.WriteLine("\nDet forstod jeg ikke.");
            }

            TryAgain(userinputAsText);
        }

        static void TryAgain(string answer)
        {
            if (answer == "y")
            {
                Console.Clear();
                myProgram();
            }
            else
            {
                Console.WriteLine("Jeg kan ikke få den til at lukke endnu, så try enter 1 gange.");
            }
        }
    }
}
