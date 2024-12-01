using Xunit;
using Day1;

namespace Day1Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData(new[] { 1, 1 }, 2)]
        [InlineData(new[] { 1000, 2000, 3000 }, 6000)]
        [InlineData(new[] { 7000, 8000, 9000 }, 24000)]
        public void SumCalories(int[] calories, int total)
        {
            Assert.Equal(total, Logic.SumCalories(calories));
        }

        [Theory]
        [InlineData(0, new[] { 1000, 2000, 3000 })]
        [InlineData(1, new[] { 4000 })]
        [InlineData(2, new[] { 5000, 6000 })]
        [InlineData(3, new[] { 7000, 8000, 9000 })]
        [InlineData(4, new[] { 10000 })]
        public void SplitElves(int elfNumber, int[] calories)
        {
            string input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

            Assert.Equal(calories, Logic.SplitElves(input)[elfNumber]);
        }

        [Fact]
        public void GetHighestCalories()
        {
            string input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
            
            Assert.Equal(24000, Logic.GetHighestCalories(input));
        }
        
        [Fact]
        public void GetThreeHighestCaloriesSum()
        {
            string input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
            
            Assert.Equal(45000, Logic.GetThreeHighestCaloriesSum(input));
        }
    }
}