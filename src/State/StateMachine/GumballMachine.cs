using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    internal class GumballMachine
    {
        private const int SOLD_OUT = 0;
        private const int NO_QUARTER = 1;
        private const int HAS_QUARTER = 2;
        private const int SOLD = 3;

        private int _state = SOLD_OUT;
        private int _count = 0;

        public GumballMachine(int count)
        {
            _count = count;

            if (count > 0)
            {
                _state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You can`t insert another quarter.");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("You can`t insert a quarter, the machine is sold out.");
            }
            else if (_state == SOLD)
            {
                Console.WriteLine("Please wait, we`er already giving you a gumball.");
            }
            else if (_state == NO_QUARTER)
            {
                _state = HAS_QUARTER;

                Console.WriteLine("You inserted a quarter.");
            }
        }

        public void EjectQuerter()
        {

        }

        public void TurnCrank()
        {

        }

        public void Dispense()
        {

        }
    }
}
