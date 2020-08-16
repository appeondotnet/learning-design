using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_10
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
