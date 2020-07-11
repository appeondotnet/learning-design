using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class RomanHouse : House
    {
        public override House CreateHouse()
        {
            Console.WriteLine("Roman House Builder Complete!");
            return this;
        }
    }
}
