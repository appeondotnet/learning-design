using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class SecurityControl
    {
        public void Arm()
        {
            Console.WriteLine("Security Control Arm");
        }

        public void DisArm()
        {
            Console.WriteLine("Security Control Disarm");
        }
    }
}
