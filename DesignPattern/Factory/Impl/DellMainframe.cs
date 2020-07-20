using System;

namespace Factory
{
    public class DellMainframe : IMainframe
    {
        public void Open()
        {
            Console.WriteLine("戴尔主机开机正常。");
        }
    }
}
