using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkWithState
{
    class EveningState :State
    {
        public override void WriteProgram(Work w)
        {
            if (w.IsFinish)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间： {0}点 加班哦，疲惫之极", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }
}
