using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl
{
    class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
