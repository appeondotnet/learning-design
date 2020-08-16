using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TvOnCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOnCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}
