using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class SimpleRemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }
    }
}
