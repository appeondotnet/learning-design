using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class QuackQuickly : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack quickly.");
        }
    }
}
