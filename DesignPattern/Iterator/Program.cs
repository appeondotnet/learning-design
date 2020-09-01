using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "a";
            aggregate[1] = "b";
            aggregate[2] = "c";
            aggregate[3] = "d";
            aggregate[4] = "e";
            aggregate[5] = "f";
            aggregate[6] = "g";

            Iterator iterator = new ConcreteIterator(aggregate);

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }

            string[] strArr = new string[] { "科比", "詹姆斯", "杜兰特", "诺维茨基", "东契奇", "卢比奥" };

            DotNetEnumerable enumerable = new DotNetEnumerable(strArr);

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadLine();
        }
    }
}
