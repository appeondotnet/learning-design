using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            this.Brew();
            this.AddCondiments();
            this.BoilWater();
            this.PourInCup();
            this.Other();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boil Water.");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pour in cup.");
        }

        public virtual void Other()
        { 
        
        }
    }
}
