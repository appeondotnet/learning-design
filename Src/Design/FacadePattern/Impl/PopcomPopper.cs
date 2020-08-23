using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Impl
{
    public class PopcomPopper
    {
        public void On()
        {
            Console.WriteLine("Popcom Popper On");
        }
        public void Off()
        {
            Console.WriteLine("Popcom Popper Off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcom Popper Pause");
        }
    }
}
