﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommand
{
    class NoCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("没有命令");
        }
    }
}
