using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        private Operation oper;

        public Operation SetOperation(string type)
        {
            return OperationFactory.CreateOperation(type);
        }

        public double Calculate()
        {
            return oper.Calculate(NumberA, NumberB);
        }
        public double GetResult(string type)
        {
            double result = 0;
            SetOperation(type);
            result = Calculate();
            return result;
        }
    }
}
