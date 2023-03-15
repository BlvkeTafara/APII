using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Employee : Person
    {
        public string ID { get; set; }
        public void IntroduceSelf()
        {
            Console.WriteLine("Hello my name is" + Name + "and my id is " + ID);
        }
    }
}
