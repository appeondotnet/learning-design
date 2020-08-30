using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();

            tea.PrepareRecipe();

            var caffe = new Caffe();

            caffe.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
