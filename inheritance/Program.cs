using System;

namespace inheritance
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase() //base class
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
        }
        class Dog : Animal //derived class
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("WUF!");
            }
        }
        class Cat : Animal ///derived class
        {
            public float cuteness;

            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }
        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();

            Console.WriteLine();

            Cat kitty = new Cat();
            kitty.name = "kitty";
            kitty.age = 13;
            kitty.happiness = 0.3f;
            kitty.cuteness = 0.4f;
            kitty.PrintBase();
            kitty.Meow();


            Console.ReadKey();

        }
    }
}
