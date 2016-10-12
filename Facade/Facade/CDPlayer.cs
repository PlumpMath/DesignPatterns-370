using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class CDPlayer
    {
        private Amplifier amp;
        public CDPlayer(Amplifier amp)
        {
            this.amp = amp;
        }

    }
}
