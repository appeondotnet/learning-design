using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourIncup();

            //hook
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public void BoilWater()
        {
            Console.WriteLine("开始将水煮至沸腾！");
        }

        public void PourIncup()
        {
            Console.WriteLine("将饮品全部放入杯子中！");
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public virtual Boolean CustomerWantsCondiments()
        {
            return true;
        }
    }
}
