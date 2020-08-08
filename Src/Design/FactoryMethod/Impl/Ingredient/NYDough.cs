using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class NYDough : IDough
    {
        public NYDough()
        {
            this.Name = "NY Dough";
        }

        public string Name { get; }
    }
}
