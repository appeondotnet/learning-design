using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class NYCheese : ICheese
    {
        public NYCheese()
        {
            this.Name = "NY Cheese";
        }

        public string Name { get; }
    }
}
