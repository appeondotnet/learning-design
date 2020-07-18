using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I' can't fly");
        }
    }
}
