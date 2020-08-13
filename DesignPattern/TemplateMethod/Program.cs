using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Cate chinaFood = new ChinaFood();

            chinaFood.MakeFood();

            Cate thaiFood = new ThaiFood();

            thaiFood.MakeFood();

            Console.Read();
        }
    }
}
