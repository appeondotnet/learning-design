using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class SoldSate : State
    {
        public SoldSate(GumballMachine gumballMachine) : base(gumballMachine)
        { 
        }
        public override void Dispense()
        {
            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public override void Eject()
        {
            Console.WriteLine("糖果已经售出");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("先取出糖果");
        }

        public override void TrunCrank()
        {
            Console.WriteLine("No twice truncrank");
        }
    }
}
