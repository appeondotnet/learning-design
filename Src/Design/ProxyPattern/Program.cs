using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new FileReaderProxy();

            proxy.ReadFile("d:\test.txt");

            Console.WriteLine("Hello World!");
        }
    }
}
