using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        protected abstract FlyBehavior GetFlyBehavior();
        protected abstract QuackBehavior GetQuackBehavior();
        public abstract void Display();

        public Duck()
        {
            this.flyBehavior = GetFlyBehavior();
            this.quackBehavior = GetQuackBehavior();
        }
        public void PerformQuack()
        {
            quackBehavior.Quacking();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
