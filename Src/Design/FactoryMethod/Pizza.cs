using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public Pizza(IPizzaIngredientFactory ingredientFactory, string name)
        {
            this.Name = name;
            this.PizzaIngredientFactory = ingredientFactory;
        }

        protected IPizzaIngredientFactory PizzaIngredientFactory { get; }
        protected IClam Clam { get; set; }
        protected ICheese Cheese { get; set; }
        protected ISauce Sauce { get; set; }
        protected IVeggies Veggies { get; set; }
        protected IPepperoni Pepperoni { get; set; }
        protected string Name { get; set; }

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
