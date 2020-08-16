using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TvCommandFactory
    {
        private static readonly Lazy<Tv> _tv = new Lazy<Tv>();

        public static ICommand CreateOnCommand()
        {
            var command = new TvOnCommand(_tv.Value);

            return command;
        }

        public static ICommand CreateOffCommand()
        {
            var command = new TvOffCommand(_tv.Value);

            return command;
        }

        public static ICommand CreateTvSetInputChannelCommand()
        {
            var command = new TvSetInputChannelCommand(_tv.Value);

            return command;
        }

        public static ICommand CreateIncrVolumeCommand()
        {
            var command = new TvIncreVolumnCommand(_tv.Value);

            return command;
        }

        public static ICommand CreateDeIncrVolumeCommand()
        {
            var command = new TvDeIncreVolumnCommand(_tv.Value);

            return command;
        }
    }
}
