using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Psyduck : Duck
    {
        public Psyduck()
        {
            FlyBehavior = new FlyWithWings();

            QuackBehavior = new QuackLoudly();
        }

        public override void Display()
        {
            Console.WriteLine("I am psyduck, i can fly and quack.");
        }

    }
}
