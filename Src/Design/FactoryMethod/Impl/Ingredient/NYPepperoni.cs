using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace FactoryMethod
{
    internal class NYPepperoni : IPepperoni
    {
        public NYPepperoni()
        {
            this.Name = "NY Pepperoni";
        }

        public string Name { get; }
    }
}
