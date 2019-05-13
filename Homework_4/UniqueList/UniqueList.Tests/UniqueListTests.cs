using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Tests
{
    [TestClass]
    public class UniqueListTests
    {
        [TestMethod]
        [ExpectedException(typeof(ItemIsAlreadyExist))]
        public void Push_existing_element()
        {
            UniqueList<int> uList = new UniqueList<int>();

            uList.Push(0);
            uList.Push(1);
            uList.Push(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemIsAlreadyExist))]
        public void PushBack_existing_element()
        {
            UniqueList<int> uList = new UniqueList<int>();

            uList.PushBack(0);
            uList.PushBack(1);
            uList.PushBack(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemIsAlreadyExist))]
        public void Insert_existing_element()
        {
            UniqueList<int> uList = new UniqueList<int>();

            uList.Push(0);
            uList.Push(1);
            uList.Insert(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemDidNotExist))]
        public void Delete_unique_not_existing_element()
        {
            UniqueList<int> uList = new UniqueList<int>();

            uList.Push(0);
            uList.Push(1);
            uList.Push(2);
            uList.DeleteUnique(3);
        }

        [TestMethod]
        public void Delete_unique_existing_element()
        {
            int expected = 0;
            UniqueList<int> uList = new UniqueList<int>();

            uList.Push(0);
            uList.Push(1);
            uList.DeleteUnique(1);
            int actual = uList.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemIsAlreadyExist))]
        public void Set_existing_element()
        {
            UniqueList<int> uList = new UniqueList<int>();

            uList.Push(0);
            uList.Push(1);
            uList.Set(0, 0);
        }
    }
}