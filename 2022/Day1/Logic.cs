using System.Collections.Generic;
using System.Linq;

namespace Day1;

public class Logic
{
    public static int SumCalories(IEnumerable<int> calories)
    {
        return calories.Sum();
    }

    public static int[][] SplitElves(string input)
    {
        return input.Split("\n\n").Select(s => s.Split("\n").Select(int.Parse).ToArray()).ToArray();
    }

    public static int GetHighestCalories(string input)
    {
        int[][] elves = SplitElves(input);
        return elves.Select(SumCalories).Max();
    }

    public static int GetThreeHighestCaloriesSum(string input)
    {
        int[][] elves = SplitElves(input);

        return elves.Select(SumCalories).OrderDescending().Take(3).Sum();
    }
}