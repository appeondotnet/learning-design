using System;

namespace Facade
{
    public class Monitor
    {
        public void Open()
        {
            Console.WriteLine("开启显示器");
        }

        public void Close()
        {
            Console.WriteLine("关闭显示器");
        }
    }
}
