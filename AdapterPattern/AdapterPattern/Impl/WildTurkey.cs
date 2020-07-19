using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("我能飞，但是只能飞五分之一远！");
        }

        public void Gobble()
        {
            Console.WriteLine("红烧火鸡，滋滋滋的声音！");
        }
    }
}
