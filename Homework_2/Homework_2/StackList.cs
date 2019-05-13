using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class StackList : IStack
    {
        ListInt list;

        public StackList()
        {
            list = new ListInt();
        }

        public int Get()
        {
            return list.Top();
        }

        public void Set(int value)
        {
            list.PushBack(value);
        }
    }
}