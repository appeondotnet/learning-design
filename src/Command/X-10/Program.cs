using System;

namespace X_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var stereo = new Stereo();

            var noCommand = new NoCommand();
            var command1 = new LightOnCommand(light);
            var command2 = new StereoOnWithCDCommand(stereo);
            var command3 = new MacroComand(new ICommand[] { command1, command2 });

            var remote = new RemoteControl();

            remote.SetComand(0, command1, noCommand);
            remote.SetComand(1, command2, noCommand);
            remote.SetComand(2, command3, noCommand);

            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
        }
    }
}
