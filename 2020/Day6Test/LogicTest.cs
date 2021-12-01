using System;
using Day6;
using Xunit;

namespace Day6Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData("abc", 3)]
        [InlineData("aaaa", 1)]
        public void QuestionsAnsweredCount(string input, int result)
        {
            Assert.Equal(result, Logic.CountYesQuestions(input));
        }
        
        [Theory]
        [InlineData("a\nb b\nc", "abbc")]
        public void ConvertToOneLineTest(string input, string result)
        {
            Assert.Equal(result, Logic.ConvertToOneLine(input));
        }
        
        [Theory]
        [InlineData("abc", 3)]
        [InlineData("a\nb\nc", 0)]
        [InlineData("ab\nac", 1)]
        [InlineData("a\na\na\na", 1)]
        [InlineData("b", 1)]
        [InlineData("abb\na\na\na", 1)]
        [InlineData("ab\nab\nc", 0)]
        [InlineData("gqraplu\njmwftidynvozkhe", 0)]
        public void CountEveryoneYesQuestionsTest(string input, int result)
        {
            
            Assert.Equal(result, Logic.CountEveryoneYesQuestions(input.Split("\n")));
        }
        
        [Theory]
        [InlineData("abc\n\na\nb\nc\n\nab\nac\n\na\na\na\na\n\nb", 6)]
        public void Part2Test(string input, int result)
        {
            Assert.Equal(result, Logic.Part2(input));
        }
    }
}