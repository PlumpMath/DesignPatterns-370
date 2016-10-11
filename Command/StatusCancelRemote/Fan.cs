using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class Fan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        public int Speed { get; private set; }
        
        public Fan()
        {
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
            Console.WriteLine("Fan is on high");
        }

        public void Medium()
        {
            Speed = MEDIUM;
            Console.WriteLine("Fan is on medium");
        }

        public void Low()
        {
            Speed = LOW;
            Console.WriteLine("Fan is on low");
        }

        public void Off()
        {
            Speed = OFF;
            Console.WriteLine("Fan is off");
        }
    }
}
