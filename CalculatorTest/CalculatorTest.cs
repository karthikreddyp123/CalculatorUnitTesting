using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Test()
        {
            //Arrange
            int expected = 10;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = Calculator.Calculator.Add(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Test_Double()
        {
            //Arrange
            double expected = 10.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = Calculator.Calculator.Add(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Test_OverflowException()
        {
            //Arrange
            int num1 = int.MaxValue;
            int num2 = 4;
            //Act and Assert
            Assert.ThrowsException<System.OverflowException>(() => Calculator.Calculator.Add(num1, num2));
        }
        [TestMethod]
        public void Add_Test_Double_OverflowException()
        {
            //Arrange
            double num1 = double.MaxValue;
            double num2 = 4.0;
            //Act and Assert
            Assert.ThrowsException<System.OverflowException>(() => Calculator.Calculator.Add(num1, num2));
        }
        [TestMethod]
        public void Subtract_Test()
        {
            //Arrange
            int expected = 2;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = Calculator.Calculator.Subtract(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_Test_Double()
        {
            //Arrange
            double expected = 2.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = Calculator.Calculator.Subtract(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiply_Test()
        {
            //Arrange
            int expected = 24;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = Calculator.Calculator.Multiply(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiply_Test_Double()
        {
            //Arrange
            double expected = 24.0;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = Calculator.Calculator.Multiply(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test()
        {
            //Arrange
            int expected = 1;
            int num1 = 6;
            int num2 = 4;
            //Act
            int actual = Calculator.Calculator.Divide(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test_DivideByZeroException()
        {
            //Arrange
            int num1 = 6;
            int num2 = 0;
            //Act and Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => Calculator.Calculator.Divide(num1, num2));
        }
        [TestMethod]
        public void Divide_Test_Double()
        {
            //Arrange
            double expected = 1.5;
            double num1 = 6.0;
            double num2 = 4.0;
            //Act
            double actual = Calculator.Calculator.Divide(num1, num2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divide_Test_Double_DivideByZeroException()
        {
            //Arrange
            double num1 = 6;
            double num2 = 0;
            //Act and Assert
            Assert.ThrowsException<System.DivideByZeroException>(()=>Calculator.Calculator.Divide(num1,num2));
        }

    }
}
