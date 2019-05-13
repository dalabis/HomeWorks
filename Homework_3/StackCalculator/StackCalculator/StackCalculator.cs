using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class StackCalculator
    {
        static public double Calculate(string str)
        {
            StackListDouble stack = new StackListDouble();
            string[] operands = str.Split(' ');

            foreach (string oper in operands)
            {
                double number;
                double second;
                double first;

                bool success = Double.TryParse(oper, out number);
                if (success)
                {
                    stack.Set(number);
                }
                else
                {
                    switch (oper)
                    {
                        case "+":
                            second = stack.Get();
                            first = stack.Get();
                            stack.Set(first + second);
                            break;
                        case "-":
                            second = stack.Get();
                            first = stack.Get();
                            stack.Set(first - second);
                            break;
                        case "*":
                            second = stack.Get();
                            first = stack.Get();
                            stack.Set(first * second);
                            break;
                        case "/":
                            second = stack.Get();
                            first = stack.Get();
                            stack.Set(first / second);
                            break;
                        default:
                            Console.WriteLine("Unknown operand ", oper);
                            break;
                    }
                }
            }

            return stack.Get();
        }

        static public string ToPostfixNotation(string infixExpession)
        {
            string postfixExpression = "";
            StackListString stack = new StackListString();
            string[] operands = infixExpession.Split(' ');

            // читаем очередной символ
            foreach (string oper in operands)
            {
                double number;

                // Если символ является числом, добавляем его к выходной строке.
                bool success = Double.TryParse(oper, out number);
                if (success)
                {
                    postfixExpression += oper;
                    postfixExpression += " ";
                }
                // Если символ является открывающей скобкой, помещаем его в стек
                else if (oper == "(")
                {
                    stack.Set(oper);
                }
                // Если символ является закрывающей скобкой:
                // До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
                // При этом открывающая скобка удаляется из стека, но в выходную строку не добавляется
                // Если стек закончился раньше, чем мы встретили открывающую скобку, это означает, что в выражении либо неверно поставлен разделитель, либо не согласованы скобки
                else if (oper == ")")
                {
                    string temp = stack.Get();
                    stack.Set(temp);

                    while (temp != "(")
                    {
                        postfixExpression += stack.Get();
                        postfixExpression += " ";

                        temp = stack.Get();
                        stack.Set(temp);
                    }

                    // удаление открывающей скобки из стека
                    temp = stack.Get();
                }
                // Если символ является бинарной операцией o1("+", "-", "*", "/"), тогда:
                // 1) пока операция на вершине стека приоритетнее o1 выталкиваем верхний элемент стека в выходную 
                // 2) помещаем операцию o1 в стек
                else if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
                {
                    if (!stack.IsEmpty())
                    {
                        string temp = stack.Get();
                        stack.Set(temp);

                        // все случаи приоритета операций:
                        // 1. *, / приоритетнее +, -
                        // 2. /, * имеют приоритет в порядке слева направо
                        // 3. +, - имеют приоритет в порядке слева направо
                        while (((oper == "+" || oper == "-") && (temp == "*" || temp == "/")) || (oper == "+" && temp == "-") || (oper == "-" && temp == "+") || (oper == "*" && temp == "/") || (oper == "/" && temp == "*"))
                        {
                            postfixExpression += stack.Get();
                            postfixExpression += " ";

                            if (!stack.IsEmpty())
                            {
                                temp = stack.Get();
                                stack.Set(temp);
                            }
                            else
                            {
                                break;
                            }
                        }

                        stack.Set(oper);
                    }
                    else
                    {
                        stack.Set(oper);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown operand");
                }
            }
            // Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
            // В стеке должны были остаться только символы операций; если это не так, значит в выражении не согласованы скобки
            while (!stack.IsEmpty())
            {
                string temp = stack.Get();
                stack.Set(temp);

                postfixExpression += stack.Get();
                postfixExpression += " ";

                if (!(temp == "+" || temp == "-" || temp == "*" || temp == "/"))
                {
                    Console.WriteLine("brackets not matched");
                }
            }
            // удалить последний пробел
            int end = postfixExpression.Length - 1;
            postfixExpression = postfixExpression.Remove(end);

            return postfixExpression;
        }
    }
}