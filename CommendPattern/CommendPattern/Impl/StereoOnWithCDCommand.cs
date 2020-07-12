using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;
        private readonly string _cdName;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public string GetName()
        {
            return _stereo.GetName();
        }
    }
}
