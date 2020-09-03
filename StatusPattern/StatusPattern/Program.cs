using System;

namespace StatusPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(5);

            Console.WriteLine(machine.State);
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.State);
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.State);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.EjectQuarter();
        }
    }
}
