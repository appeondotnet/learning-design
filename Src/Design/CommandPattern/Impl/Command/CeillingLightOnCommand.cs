using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CeillingLightOnCommand : ICommand
    {
        private readonly CeillingLight _ceillingLight;

        public CeillingLightOnCommand(CeillingLight ceillingLight)
        {
            _ceillingLight = ceillingLight;
        }

        public void Execute()
        {
            _ceillingLight.On();
        }

        public void Undo()
        {
            _ceillingLight.Off();
        }
    }
}
