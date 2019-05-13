using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class StackCalculator
    {
        static public int Calculate(string str)
        {
            StackList stack = new StackList();
            string[] operands = str.Split(' ');

            foreach (string oper in operands)
            {
                int number;

                bool success = Int32.TryParse(oper, out number);
                if (success)
                {
                    stack.Set(number);
                }
                else
                {
                    switch (oper)
                    {
                        case "+":
                            stack.Set(stack.Get() + stack.Get());
                            break;
                        case "-":
                            stack.Set(stack.Get() - stack.Get());
                            break;
                        case "*":
                            stack.Set(stack.Get() * stack.Get());
                            break;
                        default:
                            Console.WriteLine("Unknown operand ", oper);
                            break;
                    }
                }
            }

            return stack.Get();
        }
    }
}
