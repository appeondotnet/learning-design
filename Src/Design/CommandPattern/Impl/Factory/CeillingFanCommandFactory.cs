using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class CeillingFanCommandFactory
    {
        private static Lazy<CeillingFan> _ceillingFan = new Lazy<CeillingFan>();

        public static ICommand CreateHighSpeedCommand()
        {
            var command = new CeillingFanHighCommand(_ceillingFan.Value);

            return command;
        }

        public static ICommand CreateMidiumSpeedCommand()
        {
            var command = new CeillingFanMidiumCommand(_ceillingFan.Value);

            return command;
        }

        public static ICommand CreateLowSpeedCommand()
        {
            var command = new CeillingFanLowCommand(_ceillingFan.Value);

            return command;
        }
    }
}
