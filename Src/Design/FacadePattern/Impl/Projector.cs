using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector On");
        }
        public void Off()
        {
            Console.WriteLine("Projector Off");
        }

        public void TvModel()
        {
            Console.WriteLine("Projector Tv Model");
        }
    }
}
