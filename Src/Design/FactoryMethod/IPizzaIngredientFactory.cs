using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IPizzaIngredientFactory
    {
        ICheese CreateCheese();
        ISauce CreateSauce();
        IDough CreateDough();
        IPepperoni CreatePeperoni();
        IVeggies CreateVeggies();
        IClam CreateClam();
    }
}
