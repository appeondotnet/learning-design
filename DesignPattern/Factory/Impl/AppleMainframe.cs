using System;

namespace Factory
{
    public class AppleMainframe : IMainframe
    {
        public void Open()
        {
            Console.WriteLine("苹果主机开机正常。");
        }
    }
}
