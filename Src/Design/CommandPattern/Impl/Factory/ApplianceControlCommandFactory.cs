using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Impl.Factory
{
    class ApplianceControlCommandFactory
    {
        private static Lazy<ApplianceControl> _applianceControl = new Lazy<ApplianceControl>();

        public static ICommand CreateOnCommand()
        {
            var command = new ApplianceControlOnCommand(_applianceControl.Value);

            return command;
        }

        public static ICommand CreateOffCommand()
        {
            var command = new ApplianceControlOffCommand(_applianceControl.Value);

            return command;
        }
    }
}
