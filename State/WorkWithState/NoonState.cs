﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkWithState
{
    class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间： {0}点 饿了，午饭；犯困， 午休。", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}
