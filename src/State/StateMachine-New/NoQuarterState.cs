using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine_New
{
    internal class NoQuarterState : IState
    {
        private readonly GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");

            _machine.CurrentState = _machine.HasQuarterState;
        }

        public void EjectQuerter()
        {
            Console.WriteLine("You haven't inserterd a quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }
    }
}
