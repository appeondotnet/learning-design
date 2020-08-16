using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class ApplianceControl
    {
        public void On()
        {
            Console.WriteLine("ApplianceControl On.");
        }

        public void Off()
        {
            Console.WriteLine("ApplianceControl Off.");
        }
    }
}
