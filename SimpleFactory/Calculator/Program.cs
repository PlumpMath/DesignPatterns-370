using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //乱写，用到简单工厂模式但是不知道有没有用到策略模式
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                Console.Write("请输入数字A：");
                calculator.NumberA = Convert.ToDouble(Console.ReadLine());
                Console.Write("请输入运算符号（+、-、*、/）：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                calculator.NumberB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("结果是：" + calculator.GetResult(strOperate));
            }
            catch(Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
}
