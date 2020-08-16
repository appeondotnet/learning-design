using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
