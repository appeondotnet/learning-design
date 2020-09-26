using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class HasQuarterState : State
    {
        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        { 
        }

        public override void Dispense()
        {
            Console.WriteLine("没有糖果售出");
        }

        public override void Eject()
        {
            Console.WriteLine("正在退出钱");

            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("已经有钱，不能重复插入");
        }

        public override void TrunCrank()
        {
            Console.WriteLine("TrunCrank");

            Random random = new Random();

            var v = random.Next(0, 10);

            if (v == 0)
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }
    }
}
