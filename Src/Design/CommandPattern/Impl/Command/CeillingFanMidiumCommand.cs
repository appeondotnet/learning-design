using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CommandPattern
{
    class CeillingFanMidiumCommand : ICommand
    {
        private readonly CeillingFan _ceillingFan;
        private Speed _speed;

        public CeillingFanMidiumCommand(CeillingFan ceillingFan)
        {
            _ceillingFan = ceillingFan;
        }

        public void Execute()
        {
            _speed = _ceillingFan.Speed;

            _ceillingFan.SetMidium();
        }

        public void Undo()
        {
            switch (_speed)
            {
                case Speed.High:
                    {
                        _ceillingFan.SetHigh();

                        break;
                    }
                case Speed.Low:
                    {
                        _ceillingFan.SetLow();

                        break;
                    }
            }
        }
    }
}
