using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Component
{
    internal class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("PopcornPopper state is On!");
        }

        public void Off()
        {
            Console.WriteLine("PopcornPopper state is Off!");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper is adjusted to Pop style!");
        }
    }
}
