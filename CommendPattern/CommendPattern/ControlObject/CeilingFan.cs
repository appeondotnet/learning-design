using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CommandPattern
{
    internal class CeilingFan
    {
        private readonly String _location;
        private int _speed;

        public readonly static int HIGH = 3;
        public readonly static int MEDIUM = 2;
        public readonly static int LOW = 1;
        public readonly static int OFF = 0;

        public CeilingFan(String location)
        {
            _location = location;

            _speed = OFF;
        }
        public void High()
        {
            _speed = HIGH;

            Console.WriteLine($"The CeilingFan is HIGH!");
        }

        public void Medium()
        {
            _speed = MEDIUM;

            Console.WriteLine($"The CeilingFan is MEDIUM!");
        }

        public void Low()
        {
            _speed = LOW;

            Console.WriteLine($"The CeilingFan is LOW!");
        }

        public void Off()
        {
            _speed = OFF;

            Console.WriteLine($"The CeilingFan is OFF!");
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
