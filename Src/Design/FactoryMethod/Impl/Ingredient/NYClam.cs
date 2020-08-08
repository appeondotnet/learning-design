using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class NYClam : IClam
    {
        public NYClam()
        {
            this.Name = "NY Clam";
        }

        public string Name { get; }
    }
}
