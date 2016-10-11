using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneIncludeManyCommands
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

            //一次执行多条命令
            Command complexCommand = new MacroCommand(lightOn,doorOpen,stereoOn);
            Command noCommand = new NoCommand();

            remote.SetCommand(0, complexCommand, noCommand);

            Console.WriteLine(remote);
            remote.OnButtonWasPush(0);
            remote.UndoButtonWasPush();
            Console.ReadKey();
        }
    }
}
