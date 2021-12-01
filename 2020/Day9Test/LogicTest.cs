using System.Linq;
using System.Numerics;
using Day9;
using Xunit;

namespace Day9Test
{
    public class LogicTest
    {
        [Fact]
        public void ParseTest()
        {
            string input = "35\n20\n15\n25\n47\n40\n62\n55\n65\n95\n102\n117\n150\n182\n127\n219\n299\n277\n309\n576";

            long[] result = Logic.Parse(input);
            
            Assert.Equal(20, result.Length);
            Assert.Equal(35, result[0]);
            Assert.Equal(576, result[19]);
            
        }
        
        [Theory]
        [InlineData(new long[] {35, 20, 15, 25, 47}, 40)]
        [InlineData(new long[] {20, 15, 25, 47, 40}, 62)]
        [InlineData(new long[] {15, 25, 47, 40, 62}, 55)]
        public void PreambleSumTest(long[] preAmble, int target)
        {
            Assert.True(Logic.IsInPreambleSum(preAmble, target));

        }
        
        [Theory]
        [InlineData(new long[] {95, 102, 117, 150, 182}, 127)]
        public void PreambleInvalidSumTest(long[] preAmble, int target)
        {
            Assert.False(Logic.IsInPreambleSum(preAmble, target));

        }

        [Fact]
        public void Part2()
        {
            string input = "35\n20\n15\n25\n47\n40\n62\n55\n65\n95\n102\n117\n150\n182\n127\n219\n299\n277\n309\n576";
            long target = 127;
            
            Assert.Equal(62, Logic.Part2(input, target));
        }
    }
}