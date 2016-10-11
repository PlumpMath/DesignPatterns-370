using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreButtonRemoteControl
{
    class StereoOnWithCDCommand : Command
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}
