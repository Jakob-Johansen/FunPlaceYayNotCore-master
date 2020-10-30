using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog("Rottweiler");
            Fish fish = new Fish();

            Console.WriteLine("Type: " + dog.animal.AnimalType);
            Console.WriteLine("Hunderace: " + dog.DogBreed);
            Console.WriteLine("Alder: " + dog.animal.Age);
            dog.animal.Sleep();
            dog.walk.Walking();

            Console.WriteLine();

            Console.WriteLine("Type: " + fish.animal.AnimalType);
            Console.WriteLine("Alder: " + fish.animal.Age);
            fish.animal.Sleep();
            fish.swim.Swimming();
            

        }
    }
}
