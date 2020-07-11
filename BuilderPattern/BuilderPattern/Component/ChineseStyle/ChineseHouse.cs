using BuilderPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class ChineseHouse : House
    {
        public override House CreateHouse()
        {
            Console.WriteLine("Chinese House Builder Complete!");
            return this;
        }
    }
}
