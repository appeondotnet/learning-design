using System;

namespace DesignPartterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 策略模式

            Duck duck;

            duck = new GreenDuck();

            duck.PerformFly(new FlyWithWings());

            Duck duck1;

            duck1 = new RedDuck();

            duck1.PerformQuack(new MuteQuack());

            #endregion


            Console.ReadKey();
        }
    }
}
