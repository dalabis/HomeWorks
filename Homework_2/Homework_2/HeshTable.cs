using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class HeshTable
    {
        private int size;
        private ListString[] keyTable;

        public HeshTable(int size)
        {
            this.size = size;

            keyTable = new ListString[size];
            for (int i = 0; i < size; i++)
            {
                keyTable[i] = new ListString();
            }
        }

        public void Insert(string value)
        {
            int key = HeshFunction(value);

            keyTable[key].Push(value);
        }

        public void Delete(string value)
        {
            int key = HeshFunction(value);

            for (int i = keyTable[key].Length() - 1; i >= 0; i--)
            {
                if (keyTable[key].Get(i) == value)
                {
                    keyTable[key].Delete(i);
                }
            }
        }

        public bool Search(string value)
        {
            int key = HeshFunction(value);

            for (int i = 0; i < keyTable[key].Length(); i++)
            {
                if (keyTable[key].Get(i) == value)
                {
                    return true;
                }
            }

            return false;
        }

        private int HeshFunction(string value)
        {
            int key = 0;

            for (int i = 0; i < value.Length; ++i)
            {
                key = (key + value[i]) % size;
            }

            return key;
        }
    }
}
