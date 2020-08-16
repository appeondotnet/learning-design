using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TvDeIncreVolumnCommand : ICommand
    {
        private readonly Tv _tv;

        public TvDeIncreVolumnCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Volume--;
        }

        public void Undo()
        {
            _tv.Volume++;
        }
    }
}
