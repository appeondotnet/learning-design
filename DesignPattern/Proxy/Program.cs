using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Proxy proxy = new Proxy();

            Console.WriteLine(proxy.Add(10, 2));

            Console.WriteLine(proxy.Subtract(10, 2));

            Console.WriteLine(proxy.Multiply(10, 2));

            Console.WriteLine(proxy.Divide(10, 2));

            Console.Read();
        }
    }
}
