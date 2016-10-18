using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNoState
{
    class Work
    {
        public int Hour { get; set; }
        public bool IsFinish { get; set; }

        public void WriteProgram()
        {
            if (Hour < 12)
            {
                Console.WriteLine("当前时间： {0}点 上午工作，精神百倍", Hour);
            }
            else if (Hour < 13)
            {
                Console.WriteLine("当前时间： {0}点 饿了，午饭；犯困， 午休。", Hour);
            }
            else if (Hour < 17)
            {
                Console.WriteLine("当前时间： {0}点 下班回家了", Hour);
            }
            else
            {
                if (IsFinish)
                {
                    Console.WriteLine("当前时间： {0}点 下班回家了", Hour);
                }
                else
                {
                    if (Hour < 12)
                    {
                        Console.WriteLine("当前时间： {0}点 加班哦，疲惫之极", Hour);
                    }
                    else
                    {
                        Console.WriteLine("当前时间： {0}点 不行了，睡者了。", Hour);
                    }
                }
            }
        }
    }
}
