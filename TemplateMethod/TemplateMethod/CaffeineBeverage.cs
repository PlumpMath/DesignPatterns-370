using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkTemplate
{
    abstract class CaffeineBeverage
    {
        //模板方法
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();
        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        //钩子方法，子类可选择覆盖或不覆盖
        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
