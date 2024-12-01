using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day1;

public class Logic
{
  public static int ExtractCalibrationValuePart1(string input)
  {
    var digits = input.Where(c => char.IsDigit(c)).Select(c => c.ToString()).ToArray();
    return int.Parse(digits[0] + digits[digits.Length - 1]);
  }

  public static int SumCalibrationValuesPart1(string[] lines)
  {
    return lines.Select(ExtractCalibrationValuePart1).Sum();
  }

  public static int ExtractCalibrationValuePart2(string input)
  {
    string replacedValues = ReplaceWordsWithDigit(input);
    return ExtractCalibrationValuePart1(replacedValues);
  }

  private static string ReplaceWordsWithDigit(string input)
  {
    Regex regex = new Regex(@"^(one|two|three|four|five|six|seven|eight|nine)");
    string newInput = "";
    for (int i = 0; i < input.Length; i++)
    {
      if (char.IsDigit(input[i]))
      {
        newInput += input[i];
        continue;
      }

      Match match = regex.Match(input.Substring(i));
      if (match.Success)
      {
        newInput += match.Value;
      }
    }

    newInput = newInput.Replace(nameof(Numbers.one), ((int)Numbers.one).ToString());
    newInput = newInput.Replace(nameof(Numbers.two), ((int)Numbers.two).ToString());
    newInput = newInput.Replace(nameof(Numbers.three), ((int)Numbers.three).ToString());
    newInput = newInput.Replace(nameof(Numbers.four), ((int)Numbers.four).ToString());
    newInput = newInput.Replace(nameof(Numbers.five), ((int)Numbers.five).ToString());
    newInput = newInput.Replace(nameof(Numbers.six), ((int)Numbers.six).ToString());
    newInput = newInput.Replace(nameof(Numbers.seven), ((int)Numbers.seven).ToString());
    newInput = newInput.Replace(nameof(Numbers.eight), ((int)Numbers.eight).ToString());
    newInput = newInput.Replace(nameof(Numbers.nine), ((int)Numbers.nine).ToString());

    return newInput;
  }

  private enum Numbers
  {
    one = 1,
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9
  }

  public static int SumCalibrationValuesPart2(string[] lines)
  {
    return lines.Select(ExtractCalibrationValuePart2).Sum();
  }
}