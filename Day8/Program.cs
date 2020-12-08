using System;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"input.txt");

            Console.WriteLine($"Part 1: {Logic.Part1(input)}");
        }
    }
}