using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Light light = new Light("Family Room");
            //LightOnCommand lightOn = new LightOnCommand(light);
            //GarageDoor garageDoor = new GarageDoor();
            //GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);

            //remote.SetCommand(lightOn);
            //Console.WriteLine(remote.ButtonWasPressed());
            //remote.SetCommand(garageDoorUp);
            //Console.WriteLine(remote.ButtonWasPressed());

            RemoteControl remote = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan();
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(3, garageDoorOpen, garageDoorClose);
            remote.SetCommand(4, stereoOn, stereoOff);

            Console.WriteLine(remote.ToString());
            Console.WriteLine(remote.OnButtonWasPushed(0));
            Console.WriteLine(remote.OnButtonWasPushed(1));
            Console.WriteLine(remote.OnButtonWasPushed(3));

            Console.WriteLine("Please press << ENTER >> to exit this program.");
            Console.ReadLine();
        }
    }
}
