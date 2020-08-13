using System;

namespace TemplateMethod
{
    public class ChinaFood : Cate
    {
        public override void Cooking()
        {
            Console.WriteLine("宫保鸡丁烹饪中");
        }

        public override void Eating()
        {
            Console.WriteLine("中国美食享受中");
        }
    }
}
