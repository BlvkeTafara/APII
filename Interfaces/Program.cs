using System;

namespace Interfaces
{
    class Program
    {
        interface IItem
        {
            string name { get; set; }
            int goldvalue { get; set; }

            void Equip();
            void Sell(); 
        }
        class Sword : IItem
        {
            public string name { get; set; }
            public int goldvalue { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldvalue = 100;
            }

            public void Equip()
            {
                Console.WriteLine(name + "equipped");
            }
            public void sell ()
            {
                Console.WriteLine(name + "sold for" + goldvalue + "imaginary dollars");
            }
        }
        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of destiny");
            sword.Equip();
            sword.sell();
            Console.ReadKey();
        }
    }
}
