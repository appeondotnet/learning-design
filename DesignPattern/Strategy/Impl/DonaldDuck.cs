using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DonaldDuck : Duck
    {
        public DonaldDuck()
        {
            QuackBehavior = new QuackQuickly();
        }

        public override void Display()
        {
            Console.WriteLine("I am donaldDuck, i can quack.");
        }
    }
}
