using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "正常收费";
            CashContext cc = new CashContext(type);
            Console.WriteLine(cc.GetResult(400));

        }
    }
}
