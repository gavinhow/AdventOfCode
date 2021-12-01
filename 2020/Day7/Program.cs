using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"input.txt");

            int result = Logic.Part1(input, "shiny gold");
            Console.WriteLine($"Part 1 {result}");
            
            int result2 = Logic.Part2(input, "shiny gold");
            Console.WriteLine($"Part 2 {result2}");
        }
    }
}