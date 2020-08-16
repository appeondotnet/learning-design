using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door Light Up.");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door Down.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door Stop.");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Door Light On.");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Door Light Off.");
        }
    }
}
