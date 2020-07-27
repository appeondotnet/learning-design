using System;

namespace Facade
{
    public class Facade
    {
        private readonly Monitor _monitor;

        private readonly Mainframe _mainframe;

        public Facade()
        {
            _monitor = new Monitor();

            _mainframe = new Mainframe();
        }

        public void Open()
        {
            Console.WriteLine("开机...");

            _monitor.Open();

            _mainframe.Open();
        }

        public void Close()
        {
            Console.WriteLine("关机...");

            _monitor.Close();

            _mainframe.Close();
        }
    }
}
