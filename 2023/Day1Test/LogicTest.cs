using Xunit;
using Day1;

namespace Day1Test
{
  public class LogicTest
  {
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void ExtractCalibrationValuePart1(string input, int total)
    {
      Assert.Equal(total, Logic.ExtractCalibrationValuePart1(input));
    }

    [Fact]
    public void SumCalibrationValuesPart1()
    {
      string[] input = new[] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" };

      Assert.Equal(142, Logic.SumCalibrationValuesPart1(input));
    }

    [Theory]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    public void ExtractCalibrationValuePart2(string input, int total)
    {
      Assert.Equal(total, Logic.ExtractCalibrationValuePart2(input));
    }

    [Fact]
    public void SumCalibrationValuesPart2()
    {
      string[] input = new[]
      {
        "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen"
      };

      Assert.Equal(281, Logic.SumCalibrationValuesPart2(input));
    }
  }
}