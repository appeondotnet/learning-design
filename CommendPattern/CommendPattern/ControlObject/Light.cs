using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class Light : IComponent
    {
        private readonly string _name;

        public Light(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} Ligth is on!");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} Ligth is off!");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
