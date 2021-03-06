﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkTemplate 
{
    class Coffe : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
                return true;
            else
                return false;
        }

        private string GetUserInput()
        {
            string answer = null;
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
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
