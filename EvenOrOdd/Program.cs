using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInputAsText;
            int PlayerInputAsNumber;
            int defaultDivideNumber = 2;
            int result;

            Console.WriteLine("****************************************");
            Console.WriteLine("* Welcome to Even Or Odd GAME SHOW!!!! *");
            Console.WriteLine("****************************************");
            Console.WriteLine("* !=! You can win a brand new CAR! !=! *");
            Console.WriteLine("****************************************");

            Console.WriteLine(string.Empty);

            Console.Write("Your EVEN OR ODD Number: ");
            playerInputAsText = Console.ReadLine();
            PlayerInputAsNumber = Convert.ToInt32(playerInputAsText);

            result = PlayerInputAsNumber % defaultDivideNumber;

            Console.WriteLine(string.Empty);

            if (result == 0)
            {
                Console.WriteLine("Your number is EVEN!!!! YAAAAAY!!!! YOU JUST WON A BRAND NEW CAR! Take the keys and go for a ride in your BRAND NEW CAR!");
            }
            else
            {
                Console.WriteLine("Your number is ODD...\nGame Over");
            }


            Console.ReadKey();
        }
    }
}
