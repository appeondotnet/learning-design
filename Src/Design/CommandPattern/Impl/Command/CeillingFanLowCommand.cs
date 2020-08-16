using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommandPattern
{
    class CeillingFanLowCommand : ICommand
    {
        private readonly CeillingFan _ceillingFan;
        private Speed _speed;

        public CeillingFanLowCommand(CeillingFan ceillingFan)
        {
            _ceillingFan = ceillingFan;
        }

        public void Execute()
        {
            _speed = _ceillingFan.Speed;

            _ceillingFan.SetHigh();
        }

        public void Undo()
        {
            if (_speed == Speed.Midium)
            {
                _ceillingFan.SetHigh();
            }
            else if (_speed == Speed.Low)
            {
                _ceillingFan.Off();
            }
        }
    }
}
