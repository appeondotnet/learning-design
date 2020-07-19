using FacadePattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private readonly Amplifier _amplifier;
        public string cdContent;

        public void On()
        {
            Console.WriteLine("CdPlayer is on!");
        }

        public void Off()
        {
            Console.WriteLine("CdPlayer is off!");
        }

        public void Eject()
        {
            Console.WriteLine("CdPlayer is off!");
        }

        public void Pause()
        {
            Console.WriteLine("CdPlayer is Pause!");
        }

        public void Play()
        {
            Console.WriteLine("CdPlayer is Play!");
        }

        public void Stop()
        {
            Console.WriteLine("CdPlayer is Stop!");
        }
    }
}
