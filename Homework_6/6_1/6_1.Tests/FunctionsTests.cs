using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6_1.Tests
{
    [TestClass]
    public class FunctionsTests
    {
        private List<int> testList;

        [TestInitialize]
        public void Initialize()
        {
            testList = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                testList.Add(i);
            }
        }

        [TestMethod]
        public void Map_list_1_2_3_func_x_to_x_mult_2_return_2_4_6()
        {
            List<int> expected = new List<int>() { 2, 4, 6 };

            List<int> actual = Functions.Map(testList, x => x * 2);

            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Filter_list_1_2_3_func_x_to_x_more_2_return_3()
        {
            List<int> expected = new List<int>() { 3 };

            List<int> actual = Functions.Filter(testList, x => x > 2);

            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Fold_list_1_2_3_intial_1_func_intermed_elem_to_intermed_mult_elem_return_6()
        {
            int expected = 6;

            int actual = Functions.Fold(testList, 1, (intermed, elem) => intermed * elem);

            Assert.AreEqual(actual, expected);
        }
    }
}