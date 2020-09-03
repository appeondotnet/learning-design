using System;
using System.Collections.Generic;
using System.Text;

namespace StatusPattern
{
    internal class GumballMachine
    {
        private readonly static int SOLD_OUT = 0;
        private readonly static int NO_QUARTER = 1;
        private readonly static int HAS_QUARTER = 2;
        private readonly static int SOLD = 3;

        public int State = SOLD_OUT;
        public int Count = 0;

        public GumballMachine(int count)
        {
            this.Count = count;

            if (count > 0)
            {
                State = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (State == HAS_QUARTER)
            {
                Console.WriteLine("你无法再投入硬币！");
            }
            else if (State == SOLD_OUT)
            {
                Console.WriteLine("现在无法投入钱，设备正在给你退回你的硬币!");
            }
            else if (State == SOLD)
            {
                Console.WriteLine("请稍等，正在初始化中！");
            }
            else if (State == NO_QUARTER)
            {
                State = HAS_QUARTER;
                Console.WriteLine("你投入了一个硬币");
            }
        }

        public void EjectQuarter()
        {
            if (State == HAS_QUARTER)
            {
                State = NO_QUARTER;
                Console.WriteLine("正在退款请稍后！");
            }
            else if (State == SOLD_OUT)
            {
                Console.WriteLine("已经卖光啦，你投不进钱，所以我也不出钱!");
            }
            else if (State == SOLD)
            {
                Console.WriteLine("你已经拿到货了，怎么给你退钱！");
            }
            else if (State == NO_QUARTER)
            {
                Console.WriteLine("没投钱怎么退钱！");
            }
        }

        public void TurnCrank()
        {
            if (State == HAS_QUARTER)
            {
                Console.WriteLine("正在把你的糖果交给你！");
                State = SOLD;
                Dispense();
            }
            else if (State == SOLD_OUT)
            {
                Console.WriteLine("请稍后手动进行退款，已经没货了!");
            }
            else if (State == SOLD)
            {
                Console.WriteLine("转过一次了，要转第二次请交钱！");
            }
            else if (State == NO_QUARTER)
            {
                Console.WriteLine("先给钱，再转动！");
            }
        }

        public void Dispense()
        {
            if (State == SOLD)
            {
                Console.WriteLine("正在给顾客放出糖果");
                Count--;
                if (Count == 0)
                {
                    Console.WriteLine("糖果已经卖完啦！");
                }
                else
                {
                    State = NO_QUARTER;
                }
            }
            else if(State==NO_QUARTER)
            {
                Console.WriteLine("你需要先进行支付");
            }
            else if(State==SOLD_OUT)
            {
                Console.WriteLine("异常的错误");
            }
            else if(State==HAS_QUARTER)
            {
                Console.WriteLine("异常的错误");
            }
        }
    }
}
