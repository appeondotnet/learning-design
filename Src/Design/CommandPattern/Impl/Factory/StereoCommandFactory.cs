using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class StereoCommandFactory
    {
        private static readonly Lazy<Stereo> _stereo = new Lazy<Stereo>();

        public static ICommand CreateOnCommand()
        {
            var command = new StereoOnCommand(_stereo.Value);

            return command;
        }

        public static ICommand CreateOffCommand()
        {
            var command = new StereoOffCommand(_stereo.Value);

            return command;
        }

        public static ICommand CreateSetCdCommand()
        {
            var command = new StereoSetCdCommand(_stereo.Value);

            return command;
        }

        public static ICommand CreateSetDvdCommand()
        {
            var command = new StereoSetDvdCommand(_stereo.Value);

            return command;
        }
    }
}
