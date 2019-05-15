using System;
using System.Collections.Generic;

namespace _6_1
{
    public class Functions
    {
        public static List<int> Map(List<int> list, Func<int, int> Func)
        {
            List<int> newList = new List<int>(); 

            foreach (int element in list)
            {
                newList.Add(Func(element));
            }

            return newList;
        }

        public static List<int> Filter(List<int> list, Func<int, bool> Func)
        {
            List<int> newList = new List<int>();

            foreach (int element in list)
            {
                if (Func(element))
                {
                    newList.Add(element);
                }
            }

            return newList;
        }

        public static int Fold(List<int> list, int intial, Func<int, int, int> Func)
        {
            int fold = intial;

            foreach (int element in list)
            {
                fold = Func(fold, element);
            }

            return fold;
        }
    }
}