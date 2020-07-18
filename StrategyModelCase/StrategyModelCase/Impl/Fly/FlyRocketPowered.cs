using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rocket!");
        }
    }
}
