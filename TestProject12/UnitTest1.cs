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

           
        }
    }

 