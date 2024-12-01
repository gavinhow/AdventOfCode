// See https://aka.ms/new-console-template for more information

using Day2;
string lines = System.IO.File.ReadAllText(@"input.txt");
Console.WriteLine("Part 1: " + Logic.CalculateTotalScore(lines));