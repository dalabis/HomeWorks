using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mapList = new List<int>();
            mapList = Functions.Map(new List<int> { 1, 2, 3 }, x => x * 2);
            foreach (int element in mapList)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            List<int> filterList = new List<int>();
            filterList = Functions.Filter(new List<int> { 1, 2, 3 }, x => x > 2);
            foreach (int element in filterList)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            int fold;
            fold = Functions.Fold(new List<int> { 1, 2, 3 }, 1, (intermediate, element) => intermediate * element);
            Console.WriteLine(fold);

            Console.ReadKey();
        }
    }
}
