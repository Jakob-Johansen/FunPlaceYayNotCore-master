using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int fizz = 3;
            int buzz = 5;

            for (int i = 1; i <= 100; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % fizz == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % buzz == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
