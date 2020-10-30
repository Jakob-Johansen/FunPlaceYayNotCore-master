using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PettingZoo
{

    class Animal
    {
        public string Name;
        public string Sound;
        
        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine(this.Name + " says " + this.Sound);
        }
    }

    class Dog : Animal
    {
        public Dog(string dogName) : base(dogName)
        {
            this.Sound = "Woof";
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("...and then runs around, an chasing his tail");
        }
    }

    class Cat : Animal
    {
        public Cat(string catName) : base(catName)
        {
            this.Sound = "Meow";
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " doesn't speak but just sits there wondering when you will feed it.");
        }
    }

    class Pig : Animal
    {
        public Pig(string pigName) : base(pigName)
        {
            this.Sound = "Oink";
        }
    }

    class Parrot : Animal
    {
        public Parrot(string parrotName) : base(parrotName)
        {
            this.Sound = "I want a cracker!";
        }
    }
}
