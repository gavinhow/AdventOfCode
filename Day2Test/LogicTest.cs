using System;
using Day2;
using Xunit;

namespace Day2Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData(1,3, 'a', "abcde")]
        [InlineData(2,9, 'c', "ccccccccc")]
        public void PasswordCheckTrue(int minimum, int maximum, char letter, string password)
        {
            Assert.True(Logic.PasswordValidCheck(minimum, maximum, letter, password));
        }
        
        [Theory]
        [InlineData(1,3, 'b', "cdefg")]
        public void PasswordCheckFalse(int minimum, int maximum, char letter, string password)
        {
            Assert.False(Logic.PasswordValidCheck(minimum, maximum, letter, password));
        }
        
        [Theory]
        [InlineData("1-3 a: abcde", 1,3, 'a', "abcde")]
        [InlineData("1-3 b: cdefg", 1,3, 'b', "cdefg")]
        [InlineData("2-9 c: ccccccccc", 2,9, 'c', "ccccccccc")]
        public void PasswordEntryParse(string input, int minimum, int maximum, char letter, string password)
        {
            PasswordEntry result = PasswordEntry.Parse(input);
            
            Assert.Equal(minimum, result.Minimum);
            Assert.Equal(maximum, result.Maximum);
            Assert.Equal(letter, result.SearchChar);
            Assert.Equal(password, result.Password);
            
        }
        
        [Theory]
        [InlineData(1,3, 'a', "abcde")]
        public void PasswordCheckPart2True(int firstIndex, int secondIndex, char letter, string password)
        {
            Assert.True(Logic.PasswordValidCheckPart2(firstIndex, secondIndex, letter, password));
        }
        
        [Theory]
        [InlineData(2,9, 'c', "ccccccccc")]
        [InlineData(1,3, 'b', "cdefg")]
        public void PasswordCheckPart2False(int firstIndex, int secondIndex, char letter, string password)
        {
            Assert.False(Logic.PasswordValidCheckPart2(firstIndex, secondIndex, letter, password));
        }
        
        [Theory]
        [InlineData(1,3, 'b', "cd")]
        public void PasswordCheckPart2LengthCheck(int firstIndex, int secondIndex, char letter, string password)
        {
            Assert.False(Logic.PasswordValidCheckPart2(firstIndex, secondIndex, letter, password));
        }
        
        [Theory]
        [InlineData(2,9, 'c', "ccc")]
        public void PasswordCheckPart2ShortButStillValid(int firstIndex, int secondIndex, char letter, string password)
        {
            Assert.True(Logic.PasswordValidCheckPart2(firstIndex, secondIndex, letter, password));
        }
    }
}