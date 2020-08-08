using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class NYSauce : ISauce
    {
        public NYSauce()
        {
            this.Name = "NY Sauce";
        }

        public string Name { get; }
    }
}
