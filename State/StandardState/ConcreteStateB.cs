using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardState
{
    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.CurrentState = new ConcreteStateA();
        }
    }
}
