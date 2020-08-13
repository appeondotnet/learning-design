using System;

namespace TemplateMethod
{
    public abstract class Cate
    {
        public void Washing()
        {
            Console.WriteLine("洗锅");
        }

        public void Firing()
        {
            Console.WriteLine("生火");
        }

        public abstract void Cooking();

        public abstract void Eating();

        public void MakeFood()
        {
            Washing();

            Firing();

            Cooking();

            Eating();
        }
    }
}
