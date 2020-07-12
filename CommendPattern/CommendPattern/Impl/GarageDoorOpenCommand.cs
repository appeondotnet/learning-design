using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public string GetName()
        {
            return _garageDoor.GetName();
        }

        public void Undo()
        {
            _garageDoor.Stop();
        }
    }
}
