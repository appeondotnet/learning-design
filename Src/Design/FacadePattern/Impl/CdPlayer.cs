using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("Cd Player On");
        }
        public void Off()
        {
            Console.WriteLine("Cd Player Off");
        }

        public void Pause()
        {
            Console.WriteLine("Cd Player Pause");
        }
    }
}
