using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_10
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Execute: NoCommand.");
        }

        public void Undo()
        {
            Console.WriteLine("Undo: NoCommand.");
        }
    }
}
