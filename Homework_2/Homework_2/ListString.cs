using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    // односвязный список string
    class ListString
    {
        private Item head;
        private int size = 0;

        private class Item
        {
            public Item next;
            public string data;

            public Item(Item next, string data)
            {
                this.next = next;
                this.data = data;
            }
        }

        // проверка на списка пустоту
        public bool IsEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // узнать длину списка
        public int Length()
        {
            return size;
        }

        // добавить элемент data в начало списка
        public void Push(string data)
        {
            Item item = new Item(head, data);
            head = item;

            size++;
        }

        // добавить элемент data в конец списка
        public void PushBack(string data)
        {
            Item item = new Item(null, data);
            Item headTemp = head;

            int i = 1;
            while (headTemp.next != null)
            {
                headTemp = headTemp.next;
                i++;
            }

            item.next = headTemp.next;
            headTemp.next = item;

            size++;
        }

        // убрать элемент из начала списка
        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
                size--;
            }
        }

        // убрать элемент из конца списка
        public void Top()
        {
            if (size == 1)
            {
                Pop();
            }
            else
            {
                Item prev = head;
                Item top = head.next;

                int i = 0;
                while (top.next != null)
                {
                    prev = prev.next;
                    top = top.next;
                    i++;
                }

                prev.next = null;

                size--;
            }
        }

        // добавить элемент data на позицию pos = 0..size-1
        public void Insert(string data, int pos)
        {
            Item item = new Item(null, data);
            Item add = head;

            int i = 1;
            while (i < pos && add.next != null)
            {
                add = add.next;
                i++;
            }

            item.next = add.next;
            add.next = item;

            size++;
        }

        // удалить элемент на позиции pos = 0..size-1
        public void Delete(int pos)
        {
            if (pos == 0)
            {
                Pop();
            }
            else
            {
                Item prev = head;
                Item item = head.next;

                int i = 1;
                while (i < pos && item.next != null)
                {
                    prev = prev.next;
                    item = item.next;
                    i++;
                }

                prev.next = item.next;

                size--;
            }
        }

        // получить элемент на позиции pos = 0..size-1
        public string Get(int pos)
        {
            Item get = head;

            int i = 0;
            while (i < pos && get.next != null)
            {
                get = get.next;
                i++;
            }

            return get.data;
        }

        // изменить значеие элемента на позиции pos = 0..size-1 на data
        public void Set(string data, int pos)
        {
            Item item = head;

            int i = 0;
            while (i < pos && item.next != null)
            {
                item = item.next;
                i++;
            }

            item.data = data;
        }
    }
}
