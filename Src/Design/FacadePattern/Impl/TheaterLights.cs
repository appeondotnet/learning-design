using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("DTheater Lights On");
        }
        public void Off()
        {
            Console.WriteLine("Theater Lights Off");
        }

        public void Dim()
        {
            Console.WriteLine("Theater Lights Dim");
        }
    }
}
