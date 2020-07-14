using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    internal class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _celingFan;
        private int _prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _celingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _celingFan.GetSpeed();

            _celingFan.Off();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _celingFan.High();
            }
            else if (_prevSpeed == CeilingFan.MEDIUM)
            {
                _celingFan.Medium();
            }
            else if (_prevSpeed == CeilingFan.LOW)
            {
                _celingFan.Low();
            }
            else if (_prevSpeed == CeilingFan.OFF)
            {
                _celingFan.Off();
            }
        }
    }
}
