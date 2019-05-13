using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLib;

namespace UniqueList
{
    public class UniqueList<T> : SingleLinkedList<T>
    {
        /// <summary>
        /// return true if the element consists in list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private bool FindElement(T element)
        {
            bool succsess = false;

            for (int i = 0; i < base.Length(); i++)
            {
                if (element.Equals(base.Get(i)))
                {
                    succsess = true;
                }
            }

            return succsess;
        }

        /// <summary>
        /// add enique element to the top of the list
        /// </summary>
        /// <param name="data"></param>
        public override void Push(T data)
        {
            if (FindElement(data))
            {
                throw new ItemIsAlreadyExist();
            }
            else
            {
                base.Push(data);
            }
        }

        /// <summary>
        /// add enique element to end of list
        /// </summary>
        /// <param name="data"></param>
        public override void PushBack(T data)
        {
            if (FindElement(data))
            {
                throw new ItemIsAlreadyExist();
            }
            else
            {
                base.PushBack(data);
            }
        }

        /// <summary>
        /// insert unique element at position 0..size-1
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public override void Insert(T data, int position)
        {
            if (FindElement(data))
            {
                throw new ItemIsAlreadyExist();
            }
            else
            {
                base.Insert(data, position);
            }
        }

        /// <summary>
        /// delete element at position = 0..size-1
        /// </summary>
        /// <param name="position"></param>
        public override void Delete(int position)
        {
            base.Delete(position);
        }

        /// <summary>
        /// delete unique element
        /// </summary>
        /// <param name="position"></param>
        public void DeleteUnique(T element)
        {
            if (!FindElement(element))
            {
                throw new ItemDidNotExist();
            }
            else
            {
                for (int i = 0; i < base.Length(); i++)
                {
                    if (element.Equals(base.Get(i)))
                    {
                        base.Delete(i);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// get element at position 0..size-1
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public override T Get(int position)
        {
            return base.Get(position);
        }

        /// <summary>
        /// change element value at position 0..size-1
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public override void Set(T data, int position)
        {
            if (FindElement(data))
            {
                throw new ItemIsAlreadyExist();
            }
            else
            {
                base.Set(data, position);
            }
        }
    }
}