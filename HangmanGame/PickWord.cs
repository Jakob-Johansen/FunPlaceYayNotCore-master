using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class PickWord
    {

        public string Word { get; private set; }

        public PickWord() { }

        public void CheckWord(string userWord)
        {
            Console.WriteLine("Velkommen til Hangman!\n");
            Console.WriteLine("Vælg et ord som skal gættes, det må ikke indeholde tal eller symboler og må heller ikke være slagn ord.");

            while (userWord.Length == 0 || userWord.Any(char.IsDigit) || userWord.Any(char.IsSymbol) || userWord.Any(char.IsPunctuation))
            {
                Console.Write("\nDit ord: ");
                userWord = Console.ReadLine().Trim().ToLower();

                if (userWord.Length != 0)
                {
                    if (userWord.Any(char.IsDigit) || userWord.Any(char.IsSymbol) || userWord.Any(char.IsPunctuation))
                        Console.WriteLine("Dit ord må ikke indeholde tal eller symboler.\n");
                    else
                    {
                        Console.WriteLine("\nDit ord er godkendt.");
                        PickThisWord(userWord);
                    }
                }
                else
                {
                    Console.WriteLine("Du skal skrive et ord.\n");
                }
            }
        }

        private void PickThisWord(string userWord)
        {
            string yesOrNo = "";

            while (yesOrNo != "y" || yesOrNo != "n")
            {
                Console.WriteLine("\nVil du lave dit ord om? (y/n)");
                yesOrNo = Console.ReadLine().Trim().ToLower();

                if (yesOrNo == "y" || yesOrNo == "n")
                {
                    if (yesOrNo == "y")
                    {
                        CheckWord("");
                        break;
                    }
                    else
                    {
                        Word = userWord;
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Det forstod jeg ikke, prøv igen.");
                }
            }
        }

    }
}
