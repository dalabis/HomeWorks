using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLib;

namespace StackCalculator
{
    public class StackListDouble : IStackDouble
    {
        SingleLinkedList<double> list;

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public StackListDouble()
        {
            list = new SingleLinkedList<double>();
        }

        public double Get()
        {
            return list.Top();
        }

        public void Set(double value)
        {
            list.PushBack(value);
        }
    }
}