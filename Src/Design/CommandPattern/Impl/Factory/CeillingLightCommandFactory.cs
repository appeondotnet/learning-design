using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CeillingLightCommandFactory
    {
        private static readonly Lazy<CeillingLight> _ceillingLight = new Lazy<CeillingLight>();
       
        public static ICommand CreateOnCommand()
        {
            var command = new CeillingLightOnCommand(_ceillingLight.Value);

            return command;
        }

        public static ICommand CreateOffCommand()
        {
            var command = new CeillingLightOffCommand(_ceillingLight.Value);

            return command;
        }
    }
}
