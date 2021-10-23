using ConsoleCalculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleCalculator.Tests
{
    [TestClass]
    public class CoreTests
    {
        public int _left = 2;
        public int _right = 2;

        [TestMethod]
        public void ShouldAdd()
        {
            var expectedResult = 4;
            var operation = new Operation("+", _left, _right);
            var functionResult = operation.DoOperation();

            Assert.AreEqual(functionResult, expectedResult);
        }

        [TestMethod]
        public void ShouldSubstract()
        {
            var expectedResult = 0;
            var operation = new Operation("-", _left, _right);
            var functionResult = operation.DoOperation();

            Assert.AreEqual(functionResult, expectedResult);
        }

        [TestMethod]
        public void ShouldMultiply()
        {
            var expectedResult = 4;
            var operation = new Operation("*", _left, _right);
            var functionResult = operation.DoOperation();

            Assert.AreEqual(functionResult, expectedResult);
        }

        [TestMethod]
        public void ShouldDivide()
        {
            var expectedResult = 1;
            var operation = new Operation("/", _left, _right);
            var functionResult = operation.DoOperation();

            Assert.AreEqual(functionResult, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void ShouldThrowExceptionForDivideByZero()
        {
            var operation = new Operation("/", _left, 0);
            operation.DoOperation();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "Operator invalid")]
        public void ShouldThrowExceptionForWrongOperator()
        {
            var operation = new Operation("text", _left, 0);
            operation.DoOperation();
        }
    }
}
