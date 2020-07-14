using CommandPattern.Impl;
using System;

namespace CommandPattern
{
    internal class Program
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

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            Console.WriteLine("\r\n");

            //Undo Command Test
            remoteControl.SetCommand(3, livingRoomLightOn, livingRoomLightOff);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\r\n");

            //CeilingFan Command Test
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(4, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(5, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\r\n");

            //MacroCommand Test
            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCD, ceilingFanHigh };
            ICommand[] partyOff = { livingRoomLightOff, stereoOffWithCD, ceilingFanOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(6, partyOnMacro, partyOffMacro);
            remoteControl.OnButtonWasPushed(6);
            remoteControl.UndoButtonWasPushed();


            Console.WriteLine(remoteControl);



        }
    }
}
