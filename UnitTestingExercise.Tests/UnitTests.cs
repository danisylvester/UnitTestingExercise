using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(10,-5,5,10)]
        [InlineData(0,0,0,0)]
        [InlineData(-5,-1,-2,-8)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var u = new UnitTestMethods();

            //Act
            var actual = u.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,4,1)]
        [InlineData(-10,5,-15)]
        [InlineData(20,-5,25)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var s = new UnitTestMethods();

            //Act
            var actual = s.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0,5,0)]
        [InlineData(-5,5,-25)]
        [InlineData(1,5,5)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();

            //Act
            int actual = m.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(6,3,2)]
        [InlineData(-10,5,-2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var d = new UnitTestMethods();
            //Act
            int actual = d.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Greeting()
        {
            //Arrange
            var g = new UnitTestMethods();

            //Act
            string actual = g.Greeting();

            //Assert
            Assert.Equal("Hello!", actual);
        }

        [Fact]
        public void MyName()
        {
            //Arrange
            var m = new UnitTestMethods();

            //Act
            string actual = m.MyName();

            //Assert
            Assert.Equal("Dani", actual);
        }
    }
}
