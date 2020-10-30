using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettingZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Snoopy");
            dog.Speak();

            Cat cat = new Cat("Garfield");
            cat.Speak();

            Pig pig = new Pig("Bacon");
            pig.Speak();

            Parrot parrot = new Parrot("Polly");
            parrot.Speak();
        }
    }
}
