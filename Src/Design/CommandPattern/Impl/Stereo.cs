using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo On.");
        }

        public void Off()
        {
            Console.WriteLine("Stereo Off.");
        }

        public void SetCd()
        {
            Console.WriteLine("Stereo Set Cd.");
        }

        public void SetDvd()
        {
            Console.WriteLine("Stereo Set Dvd.");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo Set Radio.");
        }

        public void SetVolume()
        {
            Console.WriteLine("Stereo Set Volume.");
        }
    }
}
