using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is On!");
        }

        public void Off()
        {
            Console.WriteLine("Projector is Off!");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Wide the Screen Mode!");
        }
    }
}
