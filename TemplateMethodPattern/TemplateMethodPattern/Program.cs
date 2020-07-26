using System;
using TemplateMethodPattern.Impl;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTea = new Tea();

            myTea.PrepareRecipe();

            var coffee = new CoffeeWithHook();

            coffee.PrepareRecipe();
        }
    }
}
