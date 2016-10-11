using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class FanOffCommand : Command
    {
        private Fan fan;
        private int prevSpeed;
        public FanOffCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            prevSpeed = fan.Speed;
            fan.Off();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case Fan.HIGH:
                    fan.High();
                    break;
                case Fan.MEDIUM:
                    fan.Medium();
                    break;
                case Fan.LOW:
                    fan.Low();
                    break;
                case Fan.OFF:
                    fan.Off();
                    break;
            }
        }
    }
}
