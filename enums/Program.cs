using System;

namespace enums
{
    class Program
    {
        enum Breed { BUlldog, Boxer, Gemarn, Briard };
        class Animal //base class
        {
            public string name;
            public int age;
            public float happiness;
        }
        class Dog : Animal  //derived class
        {
            public Breed breed;

            public Dog(string _name, int _age, float _happiness,Breed _breed)
            {
                name = _name;
                age = _age;
                happiness = _happiness;

                breed = _breed;
            }
            public void Print()  //prints information about our dog to the console
            {
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Happiness :" + happiness);

                Console.WriteLine("Breed :" + breed);
            }
        }
        static void Main(string[] args)
        {
            Dog hulk = new Dog("Hulk", 6, 0.7f, Breed.Boxer);
            hulk.Print();

            Console.ReadKey();
        }
    }
}
