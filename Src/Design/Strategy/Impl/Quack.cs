using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("quack quack...");
        }
    }
}
