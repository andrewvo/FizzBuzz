using System;
using FizzBuzz.App;
using Xunit;

namespace FizzBuzz.Tests
{
    public class GetOutputTests
    {
        [Fact]
        public void FizzCheck()
        {
            // Arrange
            IGetOutput subject = new GetOutput();
            int testInput = 3;
            String correctOutput = "Fizz";
            // Act
            String testOutput = subject.Get(testInput);


            // Assert
            Assert.Equal(testOutput, correctOutput);
        }


        [Fact]
        public void BuzzCheck()
        {
            // Arrange
            IGetOutput subject = new GetOutput();
            int testInput = 5;
            String correctOutput = "Buzz";
            // Act
            String testOutput = subject.Get(testInput);
            // Assert
            Assert.Equal(testOutput, correctOutput);
        }
            
        [Fact]
        public void FizzBuzzCheck()
        {
            // Arrange
            IGetOutput subject = new GetOutput();
            int testInput = 15;
            String correctOutput = "FizzBuzz";
            // Act
            String testOutput = subject.Get(testInput);
            // Assert
            Assert.Equal(testOutput, correctOutput);
        }
    }
}