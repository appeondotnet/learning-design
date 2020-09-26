using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(5);

            machine.InsertQuarter();

            machine.TrunCrank();

            machine.Dispense();
        }
    }
}
