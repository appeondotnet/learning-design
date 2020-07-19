using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class DvdPlayer
    {
        public string dvdContent;

        public void On()
        {
            Console.WriteLine("DvdPlay is on!");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlay is off!");
        }

        public void Eject()
        {
            Console.WriteLine("DvdPlay is off!");
        }

        public void Pause()
        {
            Console.WriteLine("DvdPlay is Pause!");
        }

        public void Play()
        {
            Console.WriteLine($"DvdPlay is Play {dvdContent}!");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("Set dvdPlay surroundAudio!");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Set dvdPlay surroundAudio!");
        }
    }
}
