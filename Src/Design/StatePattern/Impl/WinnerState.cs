using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class WinnerState :State
    {
        public WinnerState(GumballMachine gumball) : base(gumball)
        { 
        }

        public override void Dispense()
        {
            throw new NotImplementedException();
        }

        public override void Eject()
        {
            Console.WriteLine("已经售出");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("取出糖果");
        }

        public override void TrunCrank()
        {
            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
            }

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }
    }
}
