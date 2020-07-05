using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Behavior
{
    public class DuckFlyWithWings : IDuckFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("DuckFlyWithWings: Fly.");
        }
    }
}
