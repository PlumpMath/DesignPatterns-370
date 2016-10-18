using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkWithState
{
    class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }

        public double Hour { get; set; }
        public bool IsFinish { get; set; }

        public void SetState(State state)
        {
            current = state;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
