using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Stack Calculator: Infix notation");
            string expression = StackCalculator.ToPostfixNotation(Console.ReadLine());
            Console.WriteLine(StackCalculator.Calculate(expression));
            Console.ReadKey();
        }
    }
}