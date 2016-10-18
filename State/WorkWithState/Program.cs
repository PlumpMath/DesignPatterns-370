using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithState
{
    class Program
    {
        static void Main(string[] args)
        {
            Work emergencyWork = new Work();
            emergencyWork.Hour = 9;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 10;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 12;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 13;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 14;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 17;


            //emergencyWork.IsFinish = true;
            emergencyWork.IsFinish = false;

            emergencyWork.WriteProgram();
            emergencyWork.Hour = 19;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 22;
            emergencyWork.WriteProgram();

            Console.ReadKey();
        }
    }
}
