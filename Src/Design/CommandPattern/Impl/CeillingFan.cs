using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CeillingFan
    {
        public Speed Speed { get; private set; }

        public void SetHigh()
        {
            this.Speed = Speed.High;

            Console.WriteLine("CeillingFan Speed: High");
        }

        public void SetMidium()
        {
            this.Speed = Speed.Midium;

            Console.WriteLine("CeillingFan Speed: Midium");
        }

        public void SetLow()
        {
            this.Speed = Speed.Low;

            Console.WriteLine("CeillingFan Speed: Low");
        }

        public void Off()
        {
            Console.WriteLine("CeillingFan Off");
        }
    }

    enum Speed
    { 
        High,
        Midium,
        Low
    }
}
