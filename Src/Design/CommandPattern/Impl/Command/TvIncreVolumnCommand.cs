using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TvIncreVolumnCommand : ICommand
    {
        private readonly Tv _tv;

        public TvIncreVolumnCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Volume++;
        }

        public void Undo()
        {
            _tv.Volume--;
        }
    }
}
