using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.test


namespace ClassLibrary1
{
   

public class CalculatorTests
    {
        private readonly Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void TestAddition_ValidValues()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;
            double expectedResult = 8;

            // Act
            double actualResult = calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestAddition_InvalidValues()
        {
            // Arrange
            string invalidInput = "abc";

            // Act & Assert
            Assert.Throws<FormatException>(() => calculator.Addition(double.Parse(invalidInput), 5));
        }

        [Fact]
        public void TestDivisionEquality_DivideByZero()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.DivisionEquality(num1, num2));
        }

        // Write similar test methods for Subtraction and Multiplication operations.
    }

} 
   