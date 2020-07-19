using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner state is On");
        }

        public void Off()
        {
            Console.WriteLine("Tuner state is Off");
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner setting is adjusted to Am");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner setting is adjusted to Fm");
        }

        public void SetFrequency(float frequency)
        {
            Console.WriteLine($"The Frequency is changed to {frequency}");
        }
    }
}
