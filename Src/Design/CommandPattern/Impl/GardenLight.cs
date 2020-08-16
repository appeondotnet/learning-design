using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class GardenLight
    {
        public void SetDuskTime()
        {
            Console.WriteLine("Set Dusk Time.");
        }

        public void SetDawnTime()
        {
            Console.WriteLine("Set Dawn Time.");
        }

        public void ManualOn()
        {
            Console.WriteLine("Garden Light On.");
        }

        public void ManualOff()
        {
            Console.WriteLine("Garden Light Off.");
        }
    }
}
