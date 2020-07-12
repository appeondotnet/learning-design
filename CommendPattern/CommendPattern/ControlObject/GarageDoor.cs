using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class GarageDoor : IComponent
    {
        private readonly string _name;

        public GarageDoor(string name)
        {
            _name = name;
        }

        public void Open()
        {
            Console.WriteLine($"{_name} GarageDoor is open!");
        }

        public void Up()
        {
            Console.WriteLine($"{_name} GarageDoor is up!");
        }

        public void Down()
        {
            Console.WriteLine($"{_name} GarageDoor is down!");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} GarageDoor is stop!");
        }

        public void LigthOn()
        {
            Console.WriteLine($"{_name} GarageDoor is ligthon!");
        }

        public void LigthOff()
        {
            Console.WriteLine($"{_name} GarageDoor is ligthoff!");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
