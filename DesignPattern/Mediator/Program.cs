using System;

namespace Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PartnerA a = new PartnerA(100);

            PartnerB b = new PartnerB(100);

            Mediator mediator = new Mediator(a, b);

            a.ChangeMoney(20, mediator);

            b.ChangeMoney(10, mediator);

            Console.WriteLine($"A：{a.Money}元");

            Console.WriteLine($"B：{b.Money}元");

            Console.Read();
        }
    }
}
