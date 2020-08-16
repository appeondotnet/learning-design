using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class MacroCommand : ICommand
    {
        private readonly IReadOnlyList<ICommand> _commands;

        public MacroCommand(IReadOnlyList<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}
