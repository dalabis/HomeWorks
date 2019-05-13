using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeCalculator.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        [ExpectedException(typeof(UnknownOperandException))]
        public void Parse_UncorrectInput1_UnknownOperandExceptionExpected()
        {
            string expression = "( * P + 1 1 ) 2 )";
            Tree myTree = new Tree();

            myTree.Calculate(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(UnknownOperandException))]
        public void Parse_UncorrectInput2_UnknownOperandExceptionExpected()
        {
            string expression = "( *( + 1 1 ) 2 )";
            Tree myTree = new Tree();

            myTree.Calculate(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Parse_DevideByZero_UnknownOperandExceptionExpected()
        {
            string expression = "( / 1 0 )";
            Tree myTree = new Tree();

            myTree.Calculate(expression);
        }

        [TestMethod]
        public void Parse_Expression1()
        {
            double expected = 2;
            string expression = "( + 1 1 )";
            Tree myTree = new Tree();

            double actual = myTree.Calculate(expression);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Parse_Expression2()
        {
            double expected = 4;
            string expression = "( * ( + 1 1 ) 2 )";
            Tree myTree = new Tree();

            double actual = myTree.Calculate(expression);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Parse_Expression3()
        {
            double expected = 4;
            string expression = "( * 2 ( + 1 1 ) )";
            Tree myTree = new Tree();

            double actual = myTree.Calculate(expression);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Parse_Expression4()
        {
            double expected = 6;
            string expression = "( * 2 ( + ( / 6 3 ) 1 ) )";
            Tree myTree = new Tree();

            double actual = myTree.Calculate(expression);

            Assert.AreEqual(actual, expected);
        }
    }
}
