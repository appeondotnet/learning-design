using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        public static int APPLIANCECONTROLPLOT = 0;
        public static int TVPLOT = 1;
        public static int STEREOPLOT = 2;
        public static int CEILLINGFANPLOT = 3;
        public static int CEILLINGLIGHTPLOT = 4;

        private ICommand _currentCommand;
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = this.GetInitCommands();
            _offCommands = this.GetInitCommands();
        }

        public void SetCommand(int plot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[plot] = onCommand;
            _offCommands[plot] = offCommand;
        }

        public void On(int plot)
        {
            _currentCommand = _onCommands[plot];

            _onCommands[plot].Execute();
        }

        public void Off(int plot)
        {
            _currentCommand = _offCommands[plot];

            _offCommands[plot].Execute();
        }

        public void Undo()
        {
            _currentCommand.Undo();
        }

        private ICommand[] GetInitCommands()
        {
            ICommand[] commands =
            {
                new NullCommand(),
                new NullCommand(),
                new NullCommand(),
                new NullCommand(),
                new NullCommand(),
            };

            return commands;
        }
    }
}
