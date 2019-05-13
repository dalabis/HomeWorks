using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListLib.Tests
{
    [TestClass]
    public class ListTests
    {
        // IsEmptyTests

        [TestMethod]
        public void IsEmpty_new_trueReturned()
        {
            bool expected = true;

            SingleLinkedList<int> list = new SingleLinkedList<int>();
            bool actual = list.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_list_4_3_2_1_0_falseReturned()
        {
            bool expected = false;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            bool actual = list.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        // LengthTests

        [TestMethod]
        public void Length_new_0returned()
        {
            int expected = 0;
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            int actual = list.Length();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Length_PushBack1_Top_0returned()
        {
            int expected = 0;
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.PushBack(1);
            double temp = list.Top();
            int actual = list.Length();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Length_4_3_2_1_0_5returned()
        {
            int expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            int actual = list.Length();

            Assert.AreEqual(expected, actual);
        }

        // PushTests

        [TestMethod]
        public void Push0_new_GetPositionEqual0return0()
        {
            double expected = 0;
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.Push(0);
            double actual = list.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push5_list_4_3_2_1_0_GetPositionEqual0return5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Push(5);
            double actual = list.Get(0);

            Assert.AreEqual(expected, actual);
        }

        // PushBackTests

        [TestMethod]
        public void PushBack0_new_GetPositionEqual0return0()
        {
            double expected = 0;
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.Push(0);
            double actual = list.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PushBack5_list_4_3_2_1_0_GetPositionEqual5return5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.PushBack(5);
            double actual = list.Get(5);

            Assert.AreEqual(expected, actual);
        }

        // PopTests

        [TestMethod]
        public void Top_Push1_Push2_Top_2returned()
        {
            double expected = 2;

            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Push(1);
            list.Push(2);
            double temp = list.Top();
            double actual = list.Top();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void Pop_new_ThrowListIsEmptyException()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            double temp = list.Pop();
        }

        // TopTests

        [TestMethod]
        public void Top_Push1_Push2_1returned()
        {
            double expected = 1;

            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Push(1);
            list.Push(2);
            double actual = list.Top();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Top_PushBack1_PushBack2_Top_1returned()
        {
            double expected = 1;

            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.PushBack(1);
            list.PushBack(2);
            double temp = list.Top();
            double actual = list.Top();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void Top_new_ThrowListIsEmptyException()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            double temp = list.Top();
        }

        // InsertTests

        [TestMethod]
        public void Insert5PositionEqual0_list_4_3_2_1_0_PopReturn5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Insert(5, 0);
            double actual = list.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insert5PositionEqual4_list_4_3_2_1_0_TopReturn5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Insert(5, 4);
            double actual = list.Top();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insert5PositionEqual2_list_4_3_2_1_0_GetPositionEqual2Return5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Insert(5, 2);
            double actual = list.Get(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertPosisitionEqualMinus1_list_4_3_2_1_0_ThrowArgumentOutOfRangeException()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Insert(5, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertPosisitionEqual5_list_4_3_2_1_0_ThrowArgumentOutOfRangeException()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Insert(5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void InsertPosisitionEqual0_list_new_ThrowListIsEmptyException()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.Insert(5, 5);
        }

        // DeleteTests

        [TestMethod]
        public void DeletePosisitionEqual0_list_4_3_2_1_0_PopReturn3()
        {
            double expected = 3;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Delete(0);
            double actual = list.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeletePosisitionEqual4_list_4_3_2_1_0_TopReturn1()
        {
            double expected = 1;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Delete(4);
            double actual = list.Top();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeletePosisitionEqual2_list_4_3_2_1_0_GetPositionEqual2Return1()
        {
            double expected = 1;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Delete(2);
            double actual = list.Get(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeletePosisitionEqualMinus1_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Delete(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeletePosisitionEqual5_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Delete(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void DeletePosisitionEqual0_list_new_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.Delete(0);
        }

        // GetTests

        [TestMethod]
        public void GetPosisitionEqual0_list_4_3_2_1_0_4Returned()
        {
            double expected = 4;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            double actual = list.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPosisitionEqual4_list_4_3_2_1_0_0Returned()
        {
            double expected = 0;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            double actual = list.Get(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPosisitionEqual2_list_4_3_2_1_0_2Returned()
        {
            double expected = 2;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            double actual = list.Get(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPosisitionEqualMinus1_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            double temp = list.Get(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPosisitionEqual5_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            double temp = list.Get(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void GetPosisitionEqual0_list_new_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            double temp = list.Get(0);
        }

        // SetTests

        [TestMethod]
        public void Set5PosisitionEqual0_list_4_3_2_1_0_Get0return5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Set(5, 0);
            double actual = list.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Set5PosisitionEqual4_list_4_3_2_1_0_Ger4eturn5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Set(5, 4);
            double actual = list.Get(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Set5PosisitionEqual2_list_4_3_2_1_0_Get2return5()
        {
            double expected = 5;
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Set(5, 2);
            double actual = list.Get(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set5PosisitionEqualMinus1_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Set(5, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set5PosisitionEqual5_list_4_3_2_1_0_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Set(5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void Set0PosisitionEqual0_list_new_ThrowExceptionPositionExeedsListDimention()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            list.Set(0, 0);
        }
    }
}