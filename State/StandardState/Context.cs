using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardState
{
    class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State CurrentState
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态：" + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
