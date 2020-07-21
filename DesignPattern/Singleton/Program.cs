using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<SingletonV1> v1Bags = new ConcurrentBag<SingletonV1>();

            Parallel.For(0, 100, x =>
            {
                SingletonV1 singleton = SingletonV1.Instance;

                v1Bags.Add(singleton);
            });

            Console.WriteLine("SingletonV1：" + v1Bags.All(x => x == SingletonV1.Instance));


            ConcurrentBag<SingletonV2> v2Bags = new ConcurrentBag<SingletonV2>();

            Parallel.For(0, 100, x =>
            {
                SingletonV2 singleton = SingletonV2.Instance;

                v2Bags.Add(singleton);
            });

            Console.WriteLine("SingletonV2：" + v2Bags.All(x => x == SingletonV2.Instance));


            ConcurrentBag<SingletonV3> v3Bags = new ConcurrentBag<SingletonV3>();

            Parallel.For(0, 100, x =>
            {
                SingletonV3 singleton = SingletonV3.Instance;

                v3Bags.Add(singleton);
            });

            Console.WriteLine("SingletonV3：" + v3Bags.All(x => x == SingletonV3.Instance));


            ConcurrentBag<SingletonV4> v4Bags = new ConcurrentBag<SingletonV4>();

            Parallel.For(0, 100, x =>
            {
                SingletonV4 singleton = SingletonV4.Instance;

                v4Bags.Add(singleton);
            });

            Console.WriteLine("SingletonV4：" + v4Bags.All(x => x == SingletonV4.Instance));


            ConcurrentBag<MySingleton> genericBags = new ConcurrentBag<MySingleton>();

            Parallel.For(0, 100, x =>
            {
                MySingleton singleton = MySingleton.Instance;

                genericBags.Add(singleton);
            });

            Console.WriteLine("SingletonGeneric：" + genericBags.All(x => x == MySingleton.Instance));

            Console.Read();
        }
    }
}
