using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_10
{
    internal class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();

            _stereo.SetCD();

            _stereo.SetVolume(22);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
