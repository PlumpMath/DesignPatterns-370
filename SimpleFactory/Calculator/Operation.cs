﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class Operation
    {
       public abstract double Calculate(double numberA, double numberB);
    }
}
