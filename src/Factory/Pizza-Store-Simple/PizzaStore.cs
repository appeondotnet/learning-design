using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store_Simple
{
    internal class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = PizzaFactory.Create(type);

            pizza.Opt();

            return pizza;
        }
    }
}
