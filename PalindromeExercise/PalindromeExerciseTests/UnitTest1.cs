using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("lobster", false)]
        [InlineData("gecko", false)]
        [InlineData("anna", true)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            bool actual = test.isAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
