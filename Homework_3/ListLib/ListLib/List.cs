using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLib
{
    /// <summary>
    /// single linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        private Item head;
        private Item tale;
        private int size = 0;

        /// <summary>
        /// list item, stores the value and pointer to the next item
        /// </summary>
        private class Item
        {
            public Item next;
            public T data;

            public Item(Item next, T data)
            {
                this.next = next;
                this.data = data;
            }
        }

        /// <summary>
        /// returns a pointer to the element standing at the specified position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private Item Search(int position)
        {
            Item item = head;

            for (int i = 0; i < position && item.next != null; i++)
            {
                item = item.next;
            }

            return item;
        }

        /// <summary>
        /// checking on the list is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => size == 0;

        /// <summary>
        /// find out the length of the list
        /// </summary>
        /// <returns></returns>
        public int Length() => size;

        /// <summary>
        /// add element to the top of the list
        /// </summary>
        /// <param name="data"></param>
        public virtual void Push(T data)
        {
            if (size == 0)
            {
                head = new Item(null, data);
                tale = head;
            }
            else
            {
                head = new Item(head, data);
            }

            size++;
        }

        /// <summary>
        /// add element to end of list
        /// </summary>
        /// <param name="data"></param>
        public virtual void PushBack(T data)
        {
            if (size == 0)
            {
                tale = new Item(null, data);
                head = tale;
            }
            else if (size == 1)
            {
                tale.next = new Item(null, data);
                head = tale;
                tale = tale.next;
            }
            else
            {
                tale.next = new Item(null, data);
                tale = tale.next;
            }

            size++;
        }

        /// <summary>
        /// remove item from the beginning of the list and return its value
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T data;

            // exception: list is empty
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Pop' cannot be applied on the empty list");
            }
            else if (size == 1)
            {
                data = head.data;
                head = null;
                tale = null;
            }
            else
            {
                data = head.data;
                head = head.next;
            }

            size--;

            return data;
        }

        /// <summary>
        /// remove item from the end of the list
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            T data;

            // exception: list is empty
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Top' cannot be applied on the empty list");
            }
            else if (size == 1)
            {
                data = tale.data;
                tale = null;
                head = null;
            }
            else
            {
                data = tale.data;
                Item preTaleItem = Search(size - 2);
                tale = preTaleItem;
                tale.next = null;
            }

            size--;

            return data;
        }

        /// <summary>
        /// insert element at position 0..size-1
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public virtual void Insert(T data, int position)
        {
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Insert' cannot be applied on the empty list");
            }
            else if (position < 0 || position >= size)
            {
                throw new ArgumentOutOfRangeException("Argument 'position' of the function 'Insert' should be positive and less than the length of the list");
            }

            if (position == 0)
            {
                Item item = new Item(head, data);
                head = item;
            }
            else if (position == size - 1)
            {
                tale.next = new Item(null, data);
                tale = tale.next;
            }
            else
            {
                Item previousItem = Search(position - 1);
                Item item = new Item(previousItem.next, data);
                previousItem.next = item;
            }

            size++;
        }

        /// <summary>
        /// delete element at position = 0..size-1
        /// </summary>
        /// <param name="position"></param>
        public virtual void Delete(int position)
        {
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Delete' cannot be applied on the empty list");
            }
            if (position >= size || position < 0)
            {
                throw new ArgumentOutOfRangeException("Argument 'position' of the function 'Delete' should be positive and less than the length of the list");
            }

            if (position == 0 && size == 1)
            {
                head = null;
                tale = null;
            }
            else if (position == 0)
            {
                head = head.next;
            }
            else if (position == size - 1)
            {
                Item previousTaleItem = Search(position - 1);
                tale = previousTaleItem;
            }
            else
            {
                Item previousItem = Search(position - 1);
                Item item = previousItem.next;
                previousItem.next = item.next;
            }
            size--;
        }

        /// <summary>
        /// get element at position 0..size-1
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public virtual T Get(int position)
        {
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Get' cannot be applied on the empty list");
            }
            if (position >= size || position < 0)
            {
                throw new ArgumentOutOfRangeException("Argument 'position' of the function 'Get' should be positive and less than the length of the list");
            }

            Item item = Search(position);
            return item.data;

        }

        /// <summary>
        /// change element value at position 0..size-1
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public virtual void Set(T data, int position)
        {
            if (size == 0)
            {
                throw new ListIsEmptyException("Function 'Set' cannot be applied on the empty list");
            }
            if (position >= size || position < 0)
            {
                throw new ArgumentOutOfRangeException("Argument 'position' of the function 'Set' should be positive and less than the length of the list");
            }

            Item item = Search(position);
            item.data = data;
        }
    }
}