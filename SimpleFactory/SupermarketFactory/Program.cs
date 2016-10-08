using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CashSuper cs = CashFactory.CreateCashAccept("打8折");
            Console.WriteLine(cs.AcceptCash(600));

        }
    }
}
