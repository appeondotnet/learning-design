using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store
{
    internal class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = type switch
            {
                "1" => null,
                "3" => null,
                _ => new Pizza(),
            };

            pizza.Opt();

            return pizza;
        }
    }
}
