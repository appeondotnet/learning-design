using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        { 
        }

        public override void Display()
        {
            Console.WriteLine("This is RubberDuck.");
        }
    }
}
