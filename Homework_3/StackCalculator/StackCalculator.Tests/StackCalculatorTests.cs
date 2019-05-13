using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackCalculator.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class StackCalculatorTests
    {
        // Calculate tests

        [TestMethod]
        public void Calculate_12p5_plus_2_14p5returned()
        {
            double expected = 14.5;
            string expression = "12.5 2 +";

            double actual = StackCalculator.Calculate(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_12p5_minus_2_10p5returned()
        {
            double expected = 10.5;
            string expression = "12.5 2 -";

            double actual = StackCalculator.Calculate(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_12p5_multiply_2_25returned()
        {
            double expected = 25;
            string expression = "12.5 2 *";

            double actual = StackCalculator.Calculate(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_12p5_divide_2_6p25returned()
        {
            double expected = 6.25;
            string expression = "12.5 2 /";

            double actual = StackCalculator.Calculate(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_6_10_plus_4_minus_1_1_2_multiply_plus_divide_1_plus_5returned()
        {
            double expected = 5;
            string expression = "6 10 + 4 - 1 1 2 * + / 1 +";

            double actual = StackCalculator.Calculate(expression);

            Assert.AreEqual(expected, actual);
        }

        // ToPostfixNotation tests

        [TestMethod]
        public void ToPostfixNotation_1_plus_3_return_1_3_plus()
        {
            string expected = "1 3 +";
            string expression = "1 + 3";

            string actual = StackCalculator.ToPostfixNotation(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToPostfixNotation_openingBracket_1_plus_3_closingBracket_multiply_5_return_1_3_plus_5_multiply()
        {
            string expected = "1 3 + 5 *";
            string expression = "( 1 + 3 ) * 5";

            string actual = StackCalculator.ToPostfixNotation(expression);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToPostfixNotation_openingBracket_1_plus_2_closingBracket_divide_3_multiply_5_return_1_2_plus_3_divide_5_multiply()
        {
            string expected = "1 2 + 3 / 5 *";
            string expression = "( 1 + 2 ) / 3 * 5";

            string actual = StackCalculator.ToPostfixNotation(expression);

            Assert.AreEqual(expected, actual);
        }
    }
}
