using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfTheYear
{
    public enum Months { Januar, Februar, Marts, April, Maj, Juni, Juli, August, September, Oktober, November, December};

    class Program
    {
        static void Main(string[] args)
        {
            string userInputAsText;
            int userInputAsNumber;
            bool numberCheck = false;


            Console.WriteLine("Udskriv en måned via et tal program! Yaaay!\nDu skal vælge et tal mellem 1 og 12\n");

            do
            {
                Console.Write("Vælg et tal: ");
                userInputAsText = Console.ReadLine().Trim();
                userInputAsNumber = Convert.ToInt32(userInputAsText);

                if (userInputAsNumber > 0 && userInputAsNumber <= 12)
                    numberCheck = true;
                else
                    Console.WriteLine("Du valgte ikke et nummer tal 1 og 12, prøv igen.\n");

            } while (!numberCheck);

            switch (userInputAsNumber)
            {

                case 1:
                    Console.WriteLine("\nDu valgte: " + Months.Januar);
                    break;
                case 2:
                    Console.WriteLine("\nDu valgte: " + Months.Februar);
                    break;
                case 3:
                    Console.WriteLine("\nDu valgte: " + Months.Marts);
                    break;
                case 4:
                    Console.WriteLine("\nDu valgte: " + Months.April);
                    break;
                case 5:
                    Console.WriteLine("\nDu valgte: " + Months.Maj);
                    break;
                case 6:
                    Console.WriteLine("\nDu valgte: " + Months.Juni);
                    break;
                case 7:
                    Console.WriteLine("\nDu valgte: " + Months.Juli);
                    break;
                case 8:
                    Console.WriteLine("\nDu valgte: " + Months.August);
                    break;
                case 9:
                    Console.WriteLine("\nDu valgte: " + Months.September);
                    break;
                case 10:
                    Console.WriteLine("\nDu valgte: " + Months.Oktober);
                    break;
                case 11:
                    Console.WriteLine("\nDu valgte: " + Months.November);
                    break;
                default:
                    Console.WriteLine("\nDu valgte: " + Months.December);
                    break;
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
