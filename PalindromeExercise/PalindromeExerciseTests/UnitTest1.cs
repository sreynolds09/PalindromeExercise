using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
            [InlineData("civic", true)]
            [InlineData("RaceCar", true)]
            [InlineData("hello", false)]
            [InlineData("kayak", true)]
            [InlineData("noon", true)]
            [InlineData("palindrome", false)]
        public void Test1(string input, bool expected)
        {
                // Arrange
                var wordSmith = new WordSmith();

                // Act
                var actual = wordSmith.IsAPalindrome(input);

                // Assert
                Assert.Equal(expected, actual);

        }
    }
}
