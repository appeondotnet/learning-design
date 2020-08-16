using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommandPattern
{
    class CeillingFanHighCommand : ICommand
    {
        private readonly CeillingFan _ceillingFan;
        private Speed _speed;

        public CeillingFanHighCommand(CeillingFan ceillingFan)
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
                _ceillingFan.SetMidium();
            }
            else if (_speed == Speed.Low)
            {
                _ceillingFan.SetLow();
            }
        }
    }
}
