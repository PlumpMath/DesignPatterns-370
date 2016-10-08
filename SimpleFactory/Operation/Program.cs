using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.WriteLine(result);
        }
    }
}
