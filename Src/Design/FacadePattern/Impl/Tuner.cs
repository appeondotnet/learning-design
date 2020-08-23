using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner On");
        }

        public void Off()
        {
            Console.WriteLine("Tuner Off");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner Set Fm");
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner Set Am");
        }

        public void SetFrequency()
        {
            Console.WriteLine("Tuner set frequency");

        }
    }
}
