using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("TheaterLights is on!");
        }

        public void Off()
        {
            Console.WriteLine("TheaterLights is off!");
        }

        public void Dim()
        {
            Console.WriteLine("TheaterLights is adjusted to dim!");
        }
    }
}
