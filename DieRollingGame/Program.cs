using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DieRollingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            PickDice();

        }

        static void PickDice()
        {
            string userInputAsText = string.Empty;
            int userInputAsNumber = 0;

            // Hvor mange sider terningen har.
            int DiceSides = 6;

            int score = 0;

            Console.WriteLine("Velkommen til terninge spil Yay!\n");

            // Hvis ikke userInputAsText kan blive lavet om til en int eller hvis userInputAsNumber er lig med 0, så bliver dette loop kørt.
            while (!Int32.TryParse(userInputAsText, out userInputAsNumber) || userInputAsNumber == 0)
            {
                Console.Write("Vælg antal terninger du vil slå med: ");
                userInputAsText = Console.ReadLine().Trim();

                // Tjekker om userInputAsText(Som er en string) kan blive lavet om til en int.
                if (Int32.TryParse(userInputAsText, out userInputAsNumber))
                {
                    // Hvis userInputAsNumber er lig med 0 skal den udskrive den nedenstående tekst.
                    if (userInputAsNumber == 0)
                    {
                        Console.WriteLine("Du skal mindst slå med 1 terning.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nDu skal skrive et tal.");
                }
            } // Hvis brugeren skriver et tal ind som ikke er 0 slutter loopet, og går videre.

            // Hvis userInputAsNumber er størrer end 1 (Der er ingen brackets pga min if sætning kun skal gøre en ting).
            if (userInputAsNumber > 1)
                Console.WriteLine("\nDu har valgt at slå med " + userInputAsNumber + " terninger.\n");
            else
                Console.WriteLine("\nDu har valgt at slå med " + userInputAsNumber + " terning.\n");
            // --

            // Laver en instans/forkomst af metoden Random()
            Random randomNumber = new Random();
            int activeDice = 0;

            for (int i = 0; i < userInputAsNumber; i++)
            {
                activeDice = randomNumber.Next(1, 7);
                score += activeDice;
                Console.WriteLine(activeDice);
            }

            if (score == userInputAsNumber * DiceSides)
                Console.WriteLine("\nHVORDAN GJORDE DU DET!?\nDU SLOG " + userInputAsNumber + ", " + userInputAsNumber + " gange!!!");
            // ^^

            Console.WriteLine("\nDu slog i alt: " + score + " Yay!");

        }
    }
}
