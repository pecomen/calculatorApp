using calculatorTask;

namespace TestProject12
{
    public class UnitTest1
    {

       
            [Fact]
            public void TestAddition_ValidValues()
            {
                // Arrange
                double num1 = 5;
                double num2 = 3;
                double expectedResult = 8;
                var calculator = new Calculator();

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
                var calculator = new Calculator();

                // Act & Assert
                Assert.Throws<FormatException>(() => calculator.Addition(double.Parse(invalidInput), 5));
            }

        

        [Fact]
        public void TestSubtraction_ValidValues()
        {
            // Arrange
            double num1 = 10;
            double num2 = 3;
            double expectedResult = 7;
           var calculator = new Calculator();

            // Act
            double actualResult = calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestSubtraction_InvalidValues()
        {
            // Arrange
            string invalidInput = "xyz";
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<FormatException>(() => calculator.Subtraction(double.Parse(invalidInput), 5));
        }

        [Fact]
        public void TestMultiplication_ValidValues()
        {
            // Arrange
            double num1 = 4;
            double num2 = 5;
            double expectedResult = 20;
            var calculator = new Calculator();

            // Act
            double actualResult = calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestMultiplication_InvalidValues()
        {
            // Arrange
            string invalidInput = "123abc";
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<FormatException>(() => calculator.Multiplication(double.Parse(invalidInput), 5));
        }

        [Fact]
        public void TestDivisionEquality_ValidValues()
        {
            // Arrange
            double num1 = 10;
            double num2 = 2;
            double expectedResult = 5;
            var calculator = new Calculator();

            // Act
            double actualResult = calculator.DivisionEquality(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestDivisionEquality_DivideByZero()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;
            double expectedResult = 0;
            var calculator = new Calculator();

            // Act
            double actualResult = calculator.DivisionEquality(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestDivisionEquality_InvalidValues()
        {
            // Arrange
            string invalidInput = "xyz";
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<FormatException>(() => calculator.DivisionEquality(double.Parse(invalidInput), 5));
        }

        [Fact]
        public void TestAddition_MaximumValue()
        {
            // Arrange
            double num1 = double.MaxValue;
            double num2 = 1;
           var calculator = new Calculator();

            // Act & Assert
            double actualResult = calculator.Addition(num1, num2);
            
        }

        [Fact]
        public void TestMultiplication_MinimumValue()
        {
            // Arrange
            double num1 = double.MinValue;
            double num2 = 2;
            double expectedResult = double.MinValue * 2;
            var calculator = new Calculator();

            // Act
            double actualResult = calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

       
    }



}




    

 