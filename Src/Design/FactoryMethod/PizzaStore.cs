using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public void OrderPizza(PizzaStyle style)
        {
            var pizza = this.CreatePizza(style);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(PizzaStyle style);
    }
}
