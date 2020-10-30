using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!!!!!!!!!!!!!!!!!
            // Husk at finde ud af hvordan man bruger split så man ikke kan skrive tegnene "½, ^\" ind.
            //!!!!!!!!!!!!!!!!!!!
            NewGame();
        }

        static void NewGame()
        {
            PickWord pickWord = new PickWord();
            GuessWord guessWord = new GuessWord();
            //Health health = new Health();

            pickWord.CheckWord(string.Empty);
            guessWord.SetPickedWord(pickWord.Word);
            guessWord.PickAChar();

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
