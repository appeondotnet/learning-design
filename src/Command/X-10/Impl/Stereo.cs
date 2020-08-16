using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_10
{
    internal class Stereo
    {
        public void On()
        {
            Console.WriteLine("On: Stereo.");
        }

        public void SetCD()
        {
            Console.WriteLine("SetCD: Stereo.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"SetVolume: {volume}");
        }

        public void Off()
        {
            Console.WriteLine("Off: stereo");
        }
    }
}
