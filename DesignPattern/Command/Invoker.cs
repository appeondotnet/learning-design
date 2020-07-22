using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoker
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
