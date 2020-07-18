using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class FlyWhitWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
