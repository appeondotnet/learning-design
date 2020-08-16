using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class NullCommand : ICommand
    {
        public void Execute()
        { 
        }

        public void Undo()
        { 
        }
    }
}
