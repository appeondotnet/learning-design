using AdapterPattern.Impl;
using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();

            list.Add(1);
            list.Add(2);

            var iterator = new EnumeratorAdapter<int>(list.GetEnumerator());

            while (iterator.MoveNext())
            {
                var v = iterator.Current;

                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }
}
