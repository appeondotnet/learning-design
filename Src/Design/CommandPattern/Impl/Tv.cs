using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Tv
    {
        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("TV On.");
        }

        public void Off()
        {
            Console.WriteLine("TV Off.");
        }

        public void SetInputChannel()
        {
            Console.WriteLine("Set Input Channel.");
        }
    }
}
