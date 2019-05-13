using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    /// <summary>
    /// односвязный список int
    /// </summary>
    class ListInt
    {
        private Item head;
        private int size = 0;

        private class Item
        {
            public Item next;
            public int data;

            public Item(Item next, int data)
            {
                this.next = next;
                this.data = data;
            }
        }

        // возвращает указатель на элемент стоящий на указанной позиции
        private Item Search(int position)
        {
            Item item = head;

            for (int i = 0; i < position && item.next != null; i++)
            {
                item = item.next;
            }

            return item;
        }

        // проверка на списка пустоту
        public bool IsEmpty() => size == 0;

        // узнать длину списка
        public int Length() => size;

        // добавить элемент data в начало списка
        public void Push(int data)
        {
            head = new Item(head, data);
            size++;
        }

        // добавить элемент data в конец списка
        public void PushBack(int data)
        {
            if (size == 0)
            {
                Push(data);
            }
            else
            {
                Item item = new Item(null, data);
                Item backItem = Search(size);
                backItem.next = item;
                size++;
            }
        }

        // убрать элемент из начала списка и вернуть его значение
        public int Pop()
        {
            int data = head.data;
            head = head.next;

            return data;
        }

        // убрать элемент из конца списка
        public int Top()
        {
            int data;

            if (size == 1)
            {
                data = head.data;

                if (head != null)
                {
                    head = head.next;
                    size--;
                }

                return data;
            }
            else
            {
                Item prev = head;
                Item top = head.next;

                while (top.next != null)
                {
                    prev = prev.next;
                    top = top.next;
                }

                data = top.data;
                prev.next = null;
                size--;

                return data;
            }
        }

        // добавить элемент data на позицию pos = 0..size-1
        public void Insert(int data, int position)
        {
            Item previousItem = Search(position - 1);
            Item item = new Item(previousItem.next, data);
            previousItem.next = item;
            size++;
        }

        // удалить элемент на позиции pos = 0..size-1
        public void Delete(int position)
        {
            if (position == 0)
            {
                Pop();
            }
            else
            {
                Item previousItem = Search(position - 1);
                Item item = previousItem.next;
                previousItem.next = item.next;
                size--;
            }
        }

        // получить элемент на позиции position = 0..size-1
        public int Get(int position)
        {
            Item item = Search(position);
            return item.data;
        }

        // изменить значеие элемента на позиции position = 0..size-1 на data
        public void Set(int data, int position)
        {
            Item item = Search(position);
            item.data = data;
        }
    }
}
