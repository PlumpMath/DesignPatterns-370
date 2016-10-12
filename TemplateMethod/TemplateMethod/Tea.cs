using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkTemplate
{
    class Tea : CaffeineBeverage
    {

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
                return true;
            else
                return false;
        }

        //询问顾客是否添加这种事其实应该是在抽象类中实现比较好，这里只是为了说明钩子函数
        private string GetUserInput()
        {
            string answer = null;
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");
            try
            {
                answer = Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("IO error trying to read your answer");
            }
            if (answer == null)
                return "no";
            return answer;
        }
    }
}
