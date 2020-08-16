using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class TvSetInputChannelCommand : ICommand
    {
        private readonly Tv _tv;

        public TvSetInputChannelCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.SetInputChannel();
        }

        public void Undo()
        {
           // _tv.On();
        }
    }
}
