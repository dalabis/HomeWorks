using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackCalculator.Tests
{
    [TestClass]
    public class StackListTests
    {
        [TestMethod]
        public void Set1_Get_1returned()
        {
            double expected = 1;
            StackListDouble stack = new StackListDouble();

            stack.Set(1);
            double actual = stack.Get();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Set1_Set2_Get_2returned()
        {
            double expected = 2;
            StackListDouble stack = new StackListDouble();

            stack.Set(1);
            stack.Set(2);
            double actual = stack.Get();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Set1_Set2_Get_Get_1returned()
        {
            double expected = 1;
            StackListDouble stack = new StackListDouble();

            stack.Set(1);
            stack.Set(2);
            double temp = stack.Get();
            double actual = stack.Get();

            Assert.AreEqual(expected, actual);
        }
    }
}
