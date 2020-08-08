using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class NYVeggies : IVeggies
    {
        public NYVeggies()
        {
            this.Name = "NY Veggies";
        }

        public string Name { get;}
    }
}
