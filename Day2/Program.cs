using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            PasswordEntry[] numbers = lines.Select(PasswordEntry.Parse).ToArray();

            int validCount = numbers.Count(x => Logic.PasswordValidCheck(x.Minimum, x.Maximum, x.SearchChar, x.Password));
            int validCountPart2 = numbers.Count(x => Logic.PasswordValidCheckPart2(x.Minimum, x.Maximum, x.SearchChar, x.Password));
            
            Console.WriteLine("Valid Result: " + validCount);
            Console.WriteLine("Valid Result Part 2: " + validCountPart2);
        }
    }
}