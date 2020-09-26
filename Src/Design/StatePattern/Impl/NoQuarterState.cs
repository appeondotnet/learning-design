using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class NoQuarterState : State
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        { 
        }

        public override void Dispense()
        {
            Console.WriteLine("No TrunGrank");
        }

        public override void Eject()
        {
            Console.WriteLine("No Quarter");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("insert quarter");

            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public override void TrunCrank()
        {
            Console.WriteLine("No Quarter");
        }
    }
}
