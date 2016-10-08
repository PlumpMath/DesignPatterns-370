using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationFactory
    {
        public static Operation CreateOperation(string type)
        {
            Operation oper = null;
            switch(type)
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
                default :
                    throw new Exception("运算符号错误");
            }
            return oper;
        }
    }
}
