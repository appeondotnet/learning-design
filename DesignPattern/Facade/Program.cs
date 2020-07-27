using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Open();

            facade.Close();

            Console.Read();
        }
    }
}
