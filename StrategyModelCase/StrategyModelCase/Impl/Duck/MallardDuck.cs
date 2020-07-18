using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWhitWings();

            _quackBehavior = new DuckQuack();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
