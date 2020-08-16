using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_10
{
    internal class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommmand;

        public RemoteControl()
        {
            var noCommand = new NoCommand();
            var noCommands = Enumerable.Repeat<ICommand>(noCommand, 7);

            _onCommands = noCommands.ToArray();
            _offCommands = noCommands.ToArray();
        }

        public void SetComand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();

            _undoCommmand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();

            _undoCommmand = _offCommands[slot];
        }

        public void Undo()
        {
            _undoCommmand.Undo();
        }
    }
}
