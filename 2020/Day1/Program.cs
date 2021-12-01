using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            int[] numbers = lines.Select(x => int.Parse(x)).ToArray();

            KeyValuePair<int, int> pair = Logic.Find2020Pair(numbers);
            int[] trio = Logic.Find2020Trio(numbers);
            
            Console.WriteLine("Pair Result: " + pair.Key * pair.Value);
            Console.WriteLine("Trio Result: " + (trio[0] * trio[1] * trio[2] ));
        }
    }
}