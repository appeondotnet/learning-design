using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CeillingLightOffCommand : ICommand
    {
        private readonly CeillingLight _ceillingLight;

        public CeillingLightOffCommand(CeillingLight ceillingLight)
        {
            _ceillingLight = ceillingLight;
        }

        public void Execute()
        {
            _ceillingLight.Off();
        }

        public void Undo()
        {
            _ceillingLight.On();
        }
    }
}
