using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("我会飞到天上去！");
        }

        public void Quack()
        {
            Console.WriteLine("我是一只可达鸭，呱呱呱！");
        }
    }
}
