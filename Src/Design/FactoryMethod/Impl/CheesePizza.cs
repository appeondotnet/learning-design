using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory ingredientFactory, string name) : base(ingredientFactory, name)
        { 
        }

        public override void Bake()
        {
            Console.WriteLine("Bake...");
        }

        public override void Box()
        {
            Console.WriteLine("Box...");
        }

        public override void Cut()
        {
            Console.WriteLine("Cut...");
        }

        public override void Prepare()
        {
            Console.WriteLine($"{this.Name}: Prepare...");

            this.Cheese = this.PizzaIngredientFactory.CreateCheese();
            this.Sauce = this.PizzaIngredientFactory.CreateSauce();
        }
    }
}
