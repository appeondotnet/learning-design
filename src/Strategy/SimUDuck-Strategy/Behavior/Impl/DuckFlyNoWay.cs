using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Behavior
{
    public class DuckFlyNoWay : IDuckFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("DuckFlyNoWay: Fly(no fly).");
        }
    }
}
