using CommandPattern.Impl.Factory;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var ceillingLightOnCommand = CeillingLightCommandFactory.CreateOnCommand();
            var ceillingLightOffCommand = CeillingLightCommandFactory.CreateOffCommand();

            remoteControl.SetCommand(RemoteControl.CEILLINGLIGHTPLOT, ceillingLightOnCommand, ceillingLightOffCommand);

            var applianceOnCommand = ApplianceControlCommandFactory.CreateOnCommand();
            var applianceOffCommand = ApplianceControlCommandFactory.CreateOffCommand();

            remoteControl.SetCommand(RemoteControl.APPLIANCECONTROLPLOT, applianceOnCommand, applianceOffCommand);

            remoteControl.On(RemoteControl.CEILLINGLIGHTPLOT);
            remoteControl.Undo();

            Console.ReadKey();
        }
    }
}
