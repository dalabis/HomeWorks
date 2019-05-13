using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\source\repos\Homework_4\TreeCalculator\input.txt";
            string expression;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                expression = sr.ReadLine();
            }
            Tree myTree = new Tree();

            double answer = myTree.Calculate(expression);

            Console.WriteLine(expression);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}