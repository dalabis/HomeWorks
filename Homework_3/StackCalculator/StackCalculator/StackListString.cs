using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLib;

namespace StackCalculator
{
    public class StackListString : IStackString
    {
        SingleLinkedList<string> list;

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public StackListString()
        {
            list = new SingleLinkedList<string>();
        }

        public string Get()
        {
            return list.Top();
        }

        public void Set(string value)
        {
            list.PushBack(value);
        }
    }
}
