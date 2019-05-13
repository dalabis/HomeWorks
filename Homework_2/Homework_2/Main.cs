using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Stack Calculator: Reverse Polish notation");
            string expression = Console.ReadLine();
            Console.WriteLine(StackCalculator.Calculate(expression));
            Console.ReadKey();
        }
    }
}