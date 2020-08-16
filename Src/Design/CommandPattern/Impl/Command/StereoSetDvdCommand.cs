using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class StereoSetDvdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoSetDvdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.SetDvd();
        }

        public void Undo()
        {
            //_stereo.Off();
        }
    }
}
