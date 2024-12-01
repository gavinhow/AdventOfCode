// See https://aka.ms/new-console-template for more information

using Common;
using Day2;

string[] lines = await InputReader.ReadLines();
Console.WriteLine($"Part 1: {Logic.SumValidGames(lines, "12 red, 13 green, 14 blue")}");
Console.WriteLine($"Part 2: {Logic.SumPowerGames(lines)}");
