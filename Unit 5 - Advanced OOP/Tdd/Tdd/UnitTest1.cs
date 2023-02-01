using ConsoleApp1;

namespace Tdd
{
    public class ArithmeticTests
    {
        //[Fact] //used for single test

        [Theory] //used for multiple tests
        [InlineData(2,3,5)]
        [InlineData(-2,-3,-5)]
        [InlineData(2,-3,-1)]
        public void TwoNumbersAddedUpWillSum(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            int result = sut.Sum(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3,2,1)]
        [InlineData(-5,-1,-4)]
        [InlineData(-5, 1, -6)]
        public void twoNumsSubWillMinus(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //act
            int result = sut.Sub(num1,num2);

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(-5, -1, 5)]
        [InlineData(-5, 1, -5)]
        public void twoNumsMultiWillTotal(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //act
            int result = sut.Multi(num1, num2);

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(-10, -5, 2)]
        [InlineData(-25, 5, -5)]
        public void twoNumsDivideWillTotal(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //act
            int result = sut.Divide(num1, num2);

            //assert
            Assert.Equal(expected, result);
        }
    }
}