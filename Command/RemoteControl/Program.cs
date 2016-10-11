using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor door = new GarageDoor();
            GarageDoorOpenCommand doorOpen = new GarageDoorOpenCommand(door);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(doorOpen);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
