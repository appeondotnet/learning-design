using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BatterCake batterCake;

            batterCake = new ConcreteBatterCake();

            batterCake = new EggDecorator(batterCake);

            batterCake = new SausageDecorator(batterCake);

            var cost = batterCake.Cost();

            Console.WriteLine(batterCake.Description());

            batterCake = new ConcreteSauce();

            batterCake = new ChutneyDecorator(batterCake);

            batterCake = new KetchupDecorator(batterCake);

            cost += batterCake.Cost();

            Console.WriteLine(batterCake.Description());

            Console.WriteLine("总价：" + cost);

            Console.ReadLine();
        }
    }
}
