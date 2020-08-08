using FactoryMethod.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaStyle style)
        {
            var ingredientFactory = new NYPizzaIngredientFactory();

            if (style == PizzaStyle.Cheese)
            {
                return new CheesePizza(ingredientFactory, "NY Cheese Pizza");
            }
            else if (style == PizzaStyle.Clam)
            {
                return new ClamPizza(ingredientFactory, "NY Clam Pizza");
            }

            throw new NotSupportedException();
        }
    }
}
