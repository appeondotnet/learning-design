using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class ApplianceControlOffCommand : ICommand
    {
        private readonly ApplianceControl _applianceControl;

        public ApplianceControlOffCommand(ApplianceControl applianceControl)
        {
            _applianceControl = applianceControl;
        }

        public void Execute()
        {
            _applianceControl.Off();
        }

        public void Undo()
        {
            _applianceControl.On();
        }
    }
}
