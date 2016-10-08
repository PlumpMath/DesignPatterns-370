using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch(operate)
            {
                case "+":
                    oper = new Add();
                    break;
                case "-":
                    oper = new Sub();
                    break;
                case "*":
                    oper = new Mul();
                    break;
                case "/":
                    oper = new Div();
                    break;
            }
            return oper;
        }
    }
}
