using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class Stereo : IComponent
    {
        private readonly string _name;

        public Stereo(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} Stereo is on!");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} Stereo is off!");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_name} Stereo is play cd!");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_name} Stereo is play dvd!");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_name} Stereo is play radio!");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_name} Stereo volume set: {volume}!");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
