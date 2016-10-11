using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class FanHighCommand : Command
    {
        private Fan fan;
        int prevSpeed;

        public FanHighCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            prevSpeed = fan.Speed;
            fan.High();
        }

        public void Undo()
        {
            switch(prevSpeed)
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
