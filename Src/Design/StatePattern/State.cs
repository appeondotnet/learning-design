using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    abstract class State
    {
        protected readonly GumballMachine _gumballMachine;

        public State(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public abstract void InsertQuarter();

        public abstract void Eject();

        public abstract void TrunCrank();

        public abstract void Dispense();
    }
}
