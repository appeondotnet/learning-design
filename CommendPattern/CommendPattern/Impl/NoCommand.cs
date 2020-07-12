using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {

        }

        public string GetName()
        {
            return "NoCommand";
        }

        public void Undo()
        {
            
        }
    }
}
