using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Dvd Player On");
        }
        public void Off()
        {
            Console.WriteLine("Dvd Player Off");
        }

        public void Pause()
        {
            Console.WriteLine("Dvd Player Pause");
        }
    }
}
