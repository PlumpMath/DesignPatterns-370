using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Tuner
    {
        private Amplifier amp;
        public Tuner(Amplifier amp)
        {
            this.amp = amp;
        }
    }
}
