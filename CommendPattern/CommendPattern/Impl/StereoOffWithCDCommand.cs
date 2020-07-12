using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Impl
{
    internal class StereoOffWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public string GetName()
        {
            return _stereo.GetName();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
