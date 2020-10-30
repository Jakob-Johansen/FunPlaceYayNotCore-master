using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class GuessWord
    {
        public List<char> WordChars { get; private set; }

        public List<char> GoodChars { get; private set; }

        public List<char> BadChars { get; private set; }

        public Health Health { get; private set; }

        public GuessWord() {
            WordChars = new List<char>();
            GoodChars = new List<char>();
            BadChars = new List<char>();
            Health = new Health();
        }

        public void SetPickedWord(string word)
        {
            WordChars = word.ToList();
        }

        private void SetGoodArray(string userString)
        {
            char userChar;
            char.TryParse(userString, out userChar);
            GoodChars.Add(userChar);
        } 

        private void SetBadArray(string userString)
        {
            char userChar;
            char.TryParse(userString, out userChar);
            BadChars.Add(userChar);
        }

        public void PickAChar()
        {

            //Text letter Validater
            string userInputAsString = string.Empty;

            char UserInputAsChar;

            Console.WriteLine("\nDu har " + Health.Life + " liv.");

            foreach (var item in WordChars)
            {
                if (GoodChars.Contains(item))
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            // Jeg tror jeg har lavet en Danny. (Kig på mit parse og så efter kig på min if sætning)
            while (!char.TryParse(userInputAsString, out UserInputAsChar) || userInputAsString.Any(char.IsDigit) || userInputAsString.Any(char.IsSymbol) || userInputAsString.Any(char.IsPunctuation))
            {
                Console.Write("\nSkriv et bogstav: ");
                userInputAsString = Console.ReadLine().Trim().ToLower();

                if (!char.TryParse(userInputAsString, out UserInputAsChar) || userInputAsString.Any(char.IsDigit) || userInputAsString.Any(char.IsSymbol) || userInputAsString.Any(char.IsPunctuation))
                {
                    Console.WriteLine("\nDu skal skrive et bogstav.\n");
                }
                else
                {
                    if (WordChars.Contains(UserInputAsChar))
                    {
                        SetGoodArray(UserInputAsChar.ToString());
                        WinCheck();
                    }
                    else
                    {
                        SetBadArray(UserInputAsChar.ToString());
                        Health.ReduceLife();
                        WinCheck();
                    }
                }
            }
        }

        public void LooseScreen()
        {
            Console.Write("\nDU TABTE!\nDet valgte ord var: ");
            for (int i = 0; i < WordChars.Count; i++)
            {
                Console.Write(WordChars[i]);
            }
        }

        public void WinCheck()
        {
            // Tjekker om alle chars i WordChars også er i GoodChars
            if (!WordChars.Except(GoodChars).Any())
            {
                Console.Write("\nDu vandt Yay! Du gættede ordet som var: ");
                for (int i = 0; i < WordChars.Count; i++)
                {
                    Console.Write(WordChars[i]);
                }
            }
            else
            {
                if (Health.Life == 0)
                {
                    LooseScreen();
                }
                else
                {
                    PickAChar();
                }
            }
        }
    }
}
