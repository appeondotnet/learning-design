using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine_New
{
    internal interface IState
    {
        void InsertQuarter();
        void EjectQuerter();
        void TurnCrank();
        void Dispense();
    }
}
