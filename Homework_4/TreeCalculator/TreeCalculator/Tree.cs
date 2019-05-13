using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCalculator
{
    public class Tree
    {
        private Node head;

        private abstract class Node
        {
            public abstract string GetValue();
        }

        private class Expression : Node
        {
            private string operatorType;
            private Node leftParent;
            private Node rightParent;

            public Expression(string operatorType, Node leftParent, Node rightParent)
            {
                this.operatorType = operatorType;
                this.leftParent = leftParent;
                this.rightParent = rightParent;
            }

            public override string GetValue()
            {
                return operatorType;
            }

            public Node GetLeft()
            {
                return leftParent;
            }

            public Node GetRight()
            {
                return rightParent;
            }
        }

        private class Value : Node
        {
            private string number;

            public Value(string number)
            {
                this.number = number;
            }

            public override string GetValue()
            {
                return number;
            }
        }

        private Node NewExpression(string[] operands, ref int ind)
        {
            double number;

            if (operands[ind] == "(" || operands[ind] == ")")
            {
                ind++;
                return NewExpression(operands, ref ind);
            }
            else if (operands[ind] == "+" || operands[ind] == "-" || operands[ind] == "*" || operands[ind] == "/")
            {
                ind++;
                return new Expression(operands[ind - 1], NewExpression(operands, ref ind), NewExpression(operands, ref ind));
            }
            else if (Double.TryParse(operands[ind], out number))
            {
                ind++;
                return new Value(operands[ind - 1]);
            }
            else
            {
                throw new UnknownOperandException();
            }
        }

        private void Parse(string expression)
        {
            string[] operands = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int ind = 0;

            this.head = NewExpression(operands, ref ind);
        }

        private double CalcStep(Node node)
        {
            switch (node.GetValue())
            {
                case "+":
                    return CalcStep((node as Expression).GetLeft()) + CalcStep((node as Expression).GetRight());
                case "-":
                    return CalcStep((node as Expression).GetLeft()) - CalcStep((node as Expression).GetRight());
                case "*":
                    return CalcStep((node as Expression).GetLeft()) * CalcStep((node as Expression).GetRight());
                case "/":
                    if (CalcStep((node as Expression).GetRight()) == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return CalcStep((node as Expression).GetLeft()) / CalcStep((node as Expression).GetRight());
                default:
                    return Double.Parse(node.GetValue());
            }
        }

        public double Calculate(string expression)
        {
            Parse(expression);
            if (head == null)
            {
                throw new NullReferenceException();
            }

            return CalcStep(head);
        }
    }
}