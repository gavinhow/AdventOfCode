using System;
using System.Collections.Generic;
using Day1;
using Xunit;

namespace Day1Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData(2019, 1)]
        [InlineData(2010, 10)]
        [InlineData(1144, 876)]
        public void TwentyTwentySumTrue(int a, int b)
        {
            Assert.True(Logic.IsTwentyTwentyPair(a, b));
        }
        
        [Theory]
        [InlineData(2019, 435)]
        [InlineData(2010, 123)]
        [InlineData(1144, 12)]
        public void TwentyTwentySumFalse(int a, int b)
        {
            Assert.False(Logic.IsTwentyTwentyPair(a, b));
        }
        
        [Theory]
        [InlineData(new[] {2019, 1})]
        [InlineData(new[] {2019, 1, 1234, 1289})]
        [InlineData(new[] {221, 1231, 1, 20302, 2019})]
        [InlineData(new[] {123, 123213, 5234, 2010, 213,10})]
        public void Find2020PairTest(int[] numbers)
        {
            KeyValuePair<int, int> pair = Logic.Find2020Pair(numbers);
            Assert.Equal(2020, pair.Key + pair.Value);
        }

        [Theory]
        [InlineData(new[] {2019,2})]
        [InlineData(new[] {2019, 112, 1234, 1289})]
        [InlineData(new[] {221, 1231, 231, 20302, 2019})]
        [InlineData(new[] {123, 123213, 5234, 2010, 213,12})]
        public void No2020Pair(int[] numbers)
        {
            Assert.Throws<Exception>(()=> Logic.Find2020Pair(numbers));
        }
        
        [Theory]
        [InlineData(2018, 1, 1)]
        [InlineData(2010, 7, 3)]
        public void TwentyTwentyTrioSumTrue(int a, int b, int c)
        {
            Assert.True(Logic.IsTwentyTwentyTrio(a, b, c));
        }

        [Theory]
        [InlineData(new[] {2018, 1, 1})]
        [InlineData(new[] {2010, 7, 3})]
        public void Find2020TrioTest(int[] numbers)
        {
            int[] trio = Logic.Find2020Trio(numbers);
            Assert.Equal(2020, trio[0] + trio[1] + trio[2]);
    }
    }
}