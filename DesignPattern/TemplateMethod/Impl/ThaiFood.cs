using System;

namespace TemplateMethod
{
    public  class ThaiFood:Cate
    {
        public override void Cooking()
        {
            Console.WriteLine("冬阴功汤烹饪中");
        }

        public override void Eating()
        {
            Console.WriteLine("泰国美食享受中");
        }
    }
}
