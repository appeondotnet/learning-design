using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine_New
{
    internal class GumballMachine
    {
        public GumballMachine(int count)
        {
            this.Count = count;

            this.NoQuarterState = new NoQuarterState(this);
            // ...

            if (this.Count > 0)
            {
                this.CurrentState = this.NoQuarterState;
            }
            else
            {
                this.CurrentState = this.SlodOutState;
            }
        }

        public int Count { get; set; }
        public IState CurrentState { get; set; }

        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState SlodOutState { get; }
        public IState WinnerState { get; }

        public void InsertQuarter()
        {
            this.CurrentState.InsertQuarter();
        }

        public void EjectQuerter()
        {
            this.CurrentState.EjectQuerter();
        }

        public void TurnCrank()
        {
            this.CurrentState.TurnCrank();
        }

        public void Dispense()
        {
            this.CurrentState.Dispense();
        }
    }
}
