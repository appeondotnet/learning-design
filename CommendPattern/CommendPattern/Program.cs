using CommandPattern.Impl;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLigth = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLigth);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLigth);
            LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenLight);
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffWithCDCommand stereoOffWithCD = new StereoOffWithCDCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);
            remoteControl.SetCommand(2, stereoOnWithCD, stereoOffWithCD);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(3);
        }
    }
}
