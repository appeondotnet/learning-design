using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorModelCase
{
    public abstract class Beverage
    {
        protected string _description;
        public Beverage()
        {
            _description = "Unknow Beverage";
        }
        public abstract double Const();

        public virtual string GetDescription()
        {
            return _description;
        }
    }
}
