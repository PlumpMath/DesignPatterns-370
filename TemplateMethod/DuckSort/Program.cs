using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSort
{
    class Program
    {
        //实际应用中，集合类型都有一个sort方法
        //这个sort方法就是一个模板方法，
        //使用这个sort方法时，集合的类型需要实现 ICompareable 中的 CompareTo
        static void Main(string[] args)
        {
            Duck[] ducks = {
                               new Duck("Daffy", 8),
                               new Duck("Dewey", 2),
                               new Duck("Howard", 7),
                               new Duck("Louie", 2),
                               new Duck("Donald", 10),
                               new Duck("Huey", 2),
                           };
            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);
        }

        public static void Display(Duck[] ducks)
        {
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i]);
            }
        }
    }
}
