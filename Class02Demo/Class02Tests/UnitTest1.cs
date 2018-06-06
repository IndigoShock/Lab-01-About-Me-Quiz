using System;
using Class02Demo;
using Xunit;

namespace Class02Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturn2()
        {
            Assert.Equal("2", Program.FizzBuzz(2));
        }

        [Fact]
        public void CanReturnFizz()
        {
            Assert.Equal("3", Program.FizzBuzz(3));

        }

        [Fact]
        public void CanReturnBuzz()
        {
            Assert.Equal("5", Program.FizzBuzz(5));
        }

        [Theory]
        [InlineData(7, "7")]
        [InlineData(17, "17")]
        [InlineData(107, "107")]

        public void NumberTest(int value, string expectedResult)
        {
            Assert.Equal(expectedResult, Program.FizzBuzz(value));
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(99)]

        public void ReturnFizz(int value)
        {
            Assert.Equal("Fizz", Program.FizzBuzz(value));
        }

        [Theory]
        [InlineData(15)]
        public void ReturnsFizzBuzz(int value)
        {
            Assert.Equal("FizzBuzz", Program.FizzBuzz(value));
        }
    }
}
