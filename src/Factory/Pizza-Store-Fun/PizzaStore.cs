using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store_Fun
{
    internal abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = this.CreatePizza(type);

            pizza.Opt();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
