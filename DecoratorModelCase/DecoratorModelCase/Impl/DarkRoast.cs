using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorModelCase
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "DarkRoast Coffee";
        }
        public override double Const()
        {
            return 1.99;
        }
    }
}
