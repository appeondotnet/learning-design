using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mutequack mutequack...");
        }
    }
}
