using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInputNumberOneAsText;
            string userInputNumberTwoAsText;
            string userInputOperator;

            int userInputNumberOneAsNumber;
            int userInputNumberTwoAsNumber;
            int result;

            Console.WriteLine("Lommeregner v1.0\nVIGTIG! vi supporter kun (+)Plus (-)Minus (*)Gange (/)Divider");

            Console.WriteLine(string.Empty);

            Console.WriteLine("Skriv dit regnestykke:");

            Console.Write("Tal1: ");
            userInputNumberOneAsText = Console.ReadLine().Trim();
            userInputNumberOneAsNumber = Convert.ToInt32(userInputNumberOneAsText);

            Console.Write("Operator: ");
            userInputOperator = Console.ReadLine();

            Console.Write("Tal2: ");
            userInputNumberTwoAsText = Console.ReadLine().Trim();
            userInputNumberTwoAsNumber = Convert.ToInt32(userInputNumberTwoAsText);

            int a = userInputNumberOneAsNumber;
            int b = userInputNumberTwoAsNumber;
            userInputOperator.Trim();

            switch (userInputOperator)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine(a + " " + userInputOperator + " " + b + " = " + result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine(a + " " + userInputOperator + " " + b + " = " + result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine(a + " " + userInputOperator + " " + b + " = " + result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine(a + " " + userInputOperator + " " + b + " = " + result);
                    break;
                default:
                    Console.WriteLine("Der skete en fejl.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
