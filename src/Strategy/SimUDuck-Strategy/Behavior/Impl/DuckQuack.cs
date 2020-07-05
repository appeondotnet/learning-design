using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Behavior
{
    public class DuckQuack : IDuckQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("DuckQuack: Quack.");
        }
    }
}
