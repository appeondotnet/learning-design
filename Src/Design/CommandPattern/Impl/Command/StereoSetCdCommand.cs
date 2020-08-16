using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class StereoSetCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoSetCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.SetCd();
        }

        public void Undo()
        {
            //_stereo.Off();
        }
    }
}
