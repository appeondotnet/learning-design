using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyModelCase
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
