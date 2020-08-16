using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class ApplianceControlOnCommand : ICommand
    {
        private readonly ApplianceControl _applianceControl;

        public ApplianceControlOnCommand(ApplianceControl applianceControl)
        {
            _applianceControl = applianceControl;
        }

        public void Execute()
        {
            _applianceControl.On();
        }

        public void Undo()
        {
            _applianceControl.Off();
        }
    }
}
