using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext cc = null;
            string type = "满300返100";
            switch (type)
            {
                case "正常收费":
                    cc = new CashContext(new CashNormal());
                    break;
                case "满300返100":
                    cc = new CashContext(new CashReturn(300, 100));
                    break;
                case "打8折":
                    cc = new CashContext(new CashRebate(0.8));
                    break;
            }

            Console.WriteLine(cc.GetResult(500));
        }
    }
}
