using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            GarageDoor door = new GarageDoor();
            Stereo stereo = new Stereo();
            Fan fan = new Fan();

            Command lightOn = new LightOnCommand(light);
            Command lightOff = new LightOffCommand(light);

            Command doorOpen = new GarageDoorOpenCommand(door);
            Command doorClose = new GarageDoorCloseCommand(door);

            Command stereoOn = new StereoOnWithCDCommand(stereo);
            Command stereoOff = new StereoOffWithCDCommand(stereo);

            Command fanHigh = new FanHighCommand(fan);
            Command fanMedium = new FanMediumCommand(fan);
            Command fanOff = new FanOffCommand(fan);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, doorOpen, doorClose);
            remote.SetCommand(2, stereoOn, stereoOff);
            remote.SetCommand(3, fanHigh, fanOff);
            remote.SetCommand(4, fanMedium, fanOff);

            Console.WriteLine(remote);
            remote.OnButtonWasPush(3);
            remote.OnButtonWasPush(4);
            Console.WriteLine(remote);
            remote.UndoButtonWasPush();
            Console.WriteLine(remote);
            remote.UndoButtonWasPush();

            remote.OnButtonWasPush(0);
            remote.OffButtonWasPush(0);
            remote.OnButtonWasPush(1);
            remote.OffButtonWasPush(1);
            remote.OnButtonWasPush(2);
            remote.OffButtonWasPush(2);
            Console.WriteLine(remote);
            remote.UndoButtonWasPush();
            remote.UndoButtonWasPush();
            remote.UndoButtonWasPush();
            remote.UndoButtonWasPush();
            remote.UndoButtonWasPush();
            remote.UndoButtonWasPush();
            Console.ReadKey();
        }
    }
}
