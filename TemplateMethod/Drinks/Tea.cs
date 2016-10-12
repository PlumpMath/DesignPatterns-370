using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
