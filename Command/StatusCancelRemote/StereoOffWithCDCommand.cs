using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class StereoOffWithCDCommand : Command
    {
        private Stereo stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }


        public void Undo()
        {
            stereo.On();
        }
    }
}
