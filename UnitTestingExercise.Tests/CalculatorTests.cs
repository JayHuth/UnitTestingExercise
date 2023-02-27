using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2,3,5,10)]
        [InlineData(0,0,0,0)]
        [InlineData(-1,-1,-1,-3)]
        [InlineData(-2,1,1,0)]
        //Add test data <------- Completed!
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var c = new Calculator();
            

            //Act
            var actual = c.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,0)]
        [InlineData(0,0,0)]
        [InlineData(-1,2,-3)]
        [InlineData(-1,-2,1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,5,5)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 2, -2)]
        [InlineData(-2, -5, 10)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,1,2)]
        [InlineData(0, 1, 0)]
        [InlineData(-4,2,-2)]
        [InlineData(-10,-5,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c1 = new Calculator();

            //Act
            var actuaal = c1.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actuaal);

        }

    }
}
