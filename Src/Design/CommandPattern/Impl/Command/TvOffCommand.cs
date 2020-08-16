using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TvOffCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOffCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}
