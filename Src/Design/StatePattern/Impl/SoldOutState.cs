using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class SoldOutState : State
    {
        public SoldOutState(GumballMachine gumball) : base(gumball)
        { 
        }

        public override void Dispense()
        {
            Console.WriteLine("没钱");
        }

        public override void Eject()
        {
            Console.WriteLine("没钱");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("没糖果");
        }

        public override void TrunCrank()
        {
            Console.WriteLine("没钱");
        }
    }
}
