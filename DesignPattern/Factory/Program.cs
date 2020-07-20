using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AppleComputerFactory();

            var display = factory.ProduceDisplay();

            display.Show();

            var mainframe = factory.ProduceMainframe();

            mainframe.Open();

            Console.Read();
        }
    }
}
