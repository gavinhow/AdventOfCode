using System;
using System.Linq;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"input.txt");
            
            string[] groups = input.Split("\n\n").Select(Logic.ConvertToOneLine).ToArray();

            int result = groups.Select(Logic.CountYesQuestions).Sum();
            
            Console.WriteLine($"Part 1: {result}");
            
            Console.WriteLine($"Part 2: {Logic.Part2(input)}");

        }
    }
}