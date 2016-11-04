using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实请求");
        }
    }
}
