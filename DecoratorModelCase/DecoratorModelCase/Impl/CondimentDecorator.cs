using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorModelCase
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}
