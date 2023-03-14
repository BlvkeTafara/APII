using System;

namespace properties
{
    class Program
    {
        class Player
        {
            private int _health = 100;
            public int health
            {
                get
                {
                    return _health;
                }
                set
                {
                    _health = value;

                    {
                        if (value <= 0)
                        {
                            _health = 0;
                        }
                        else if (value >= 100)
                        {
                            _health = 100;
                        }
                        else
                        {
                            _health = value;
                        }
                    }
                }

            }
            static void Main(string[] args)
            {
                Player ton = new Player();
                Console.WriteLine(ton.health);
                ton.health -= 200;
                Console.WriteLine(ton.health);
                ton.health += 400;
                Console.WriteLine(ton.health);
                ton.health = 50;
                Console.WriteLine(ton.health);
                    

                Console.ReadKey();
            }
        }
    }
}


