using System;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"input.txt");

            long part1Answer = Logic.Part1(input);
            Console.WriteLine($"Part 1: {part1Answer}");
            Console.WriteLine($"Part 2: {Logic.Part2(input, part1Answer)}");
        }
    }
}