using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class Logic
    {
        public static int CountYesQuestions(string input)
        {
            return input.ToCharArray().ToHashSet().Count;
        }
        
        public static int CountEveryoneYesQuestions(string[] input)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            HashSet<char> foundThisAnswer;

            foreach (string answers in input)
            {
                foundThisAnswer = new HashSet<char>();
                foreach (char answer in answers)
                {
                    if (foundThisAnswer.Contains(answer))
                    {
                        continue;
                    }

                    if (letterCounts.ContainsKey(answer))
                    {
                        letterCounts[answer] += 1;
                    }
                    else
                    {
                        letterCounts.Add(answer, 1);
                    }
                }
            }

            return letterCounts.Count(pair => pair.Value == input.Length);
        }

        public static string ConvertToOneLine(string input)
        {
            return input.Replace("\n", "").Replace(" ", "");
        }
        
        public static int Part2(string input)
        {
            string[][] groupsPart2 = input.Split("\n\n").Select(x => x.Split("\n")).ToArray();

            int[] results = groupsPart2.Select(CountEveryoneYesQuestions).ToArray();

            return results.Sum();
        }
    }
}