using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class GumballMachine
    {
        private readonly State _noQuarterState;
        private readonly State _hasQuarterState;
        private readonly State _soldoutState;
        private readonly State _soldState;
        private readonly State _winnerState;
  
        public GumballMachine(int count)
        {
            this.Count = count;

            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldoutState = new SoldOutState(this);
            _soldState = new SoldSate(this);
            _winnerState = new WinnerState(this);

            this.CurrentState = _noQuarterState;
        }

        public int Count { get; private set; }
        private State CurrentState { get; set; }

        public void InsertQuarter()
        {
            this.CurrentState.InsertQuarter();
        }

        public void Eject()
        {
            this.CurrentState.Eject();
        }

        public void TrunCrank()
        {
            this.CurrentState.TrunCrank();
        }

        public void Dispense()
        {
            this.CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            this.Count--;
        }

        public void SetState(State state)
        {
            this.CurrentState = state;
        }

        public State HasQuarterState => _hasQuarterState;
        public State NoQuarterState => _noQuarterState;
        public State SoldState => _soldState;
        public State SoldOutState => _soldoutState;
        public State WinnerState => _winnerState;
    }
}
