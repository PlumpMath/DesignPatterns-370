using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffe coffee = new Coffe();

            Console.WriteLine("\nMaking tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
