using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkWithState
{
    class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间： {0}点 不行了，睡者了。", w.Hour);
        }
    }
}
