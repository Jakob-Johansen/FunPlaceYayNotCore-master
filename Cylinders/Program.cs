using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler
            string heightString;
            string radiusString;
            double height;
            double radius;

            // Udskriver noget info til console.
            Console.WriteLine("Cylinder Info Program (Best on the market!)\n === *10/10* ===");

            // Udskriver en tom string
            Console.WriteLine(string.Empty);

            Console.Write("Height: ");
            heightString = Console.ReadLine(); // "heightString" er lig med bruger input. 
            height = Convert.ToDouble(heightString); // string til double.

            Console.Write("Radius: ");
            radiusString = Console.ReadLine(); // "radiusString" er lig med bruger input.
            radius = Convert.ToDouble(radiusString); // string til double.

            // Udskriver en tom string
            Console.WriteLine(string.Empty);

            // Herfra kiggede jeg i opgaven pga matematik er svært.
            double pi = 3.141592654;

            // Udregner volume og surfaceArea.
            double volume = pi * radius * height;
            double surfaceArea = 2 * pi * (radius + height);

            // Udskriver resultatet
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + " square units");

            Console.ReadKey();
        }
    }
}
