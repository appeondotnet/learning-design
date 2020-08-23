using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new HomeTheaterFacade();

            facade.On();

            facade.Off();

            Console.ReadKey();
        }
    }
}
