using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange create instant of Palindrome class
            var test = new Palindrome();
            //act call the palidrome method
            var actual = test.IsAPalindrome(word);
            //assert - compare expected and actual
            Assert.Equal(expected, actual);
            

        }
    }
}
