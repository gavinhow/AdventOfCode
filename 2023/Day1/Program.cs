using System;
using System.Threading.Tasks;
using Common;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        private static async Task Run()
        {
            string[] lines = await InputReader.ReadLines();
            Console.WriteLine($"Part 1: {Logic.SumCalibrationValuesPart1(lines)}");
            Console.WriteLine($"Part 2: {Logic.SumCalibrationValuesPart2(lines)}");
        }
    }
}