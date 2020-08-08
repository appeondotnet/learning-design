using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Impl
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new NYCheese();
        }

        public IClam CreateClam()
        {
            return new NYClam();
        }

        public IDough CreateDough()
        {
            return new NYDough();
        }

        public IPepperoni CreatePeperoni()
        {
            return new NYPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new NYSauce();
        }

        public IVeggies CreateVeggies()
        {
            return new NYVeggies();
        }
    }
}
