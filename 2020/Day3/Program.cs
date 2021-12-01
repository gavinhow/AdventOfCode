using System;
using System.Numerics;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            Map map = Map.Parse(lines);

            BigInteger treeCount1 = Logic.TreeRoute(map, 1, 3);
            BigInteger treeCount2 = Logic.TreeRoute(map, 1, 1) * 
                            Logic.TreeRoute(map, 1, 3) * 
                            Logic.TreeRoute(map, 1, 5) * 
                            Logic.TreeRoute(map, 1, 7) * 
                            Logic.TreeRoute(map, 2, 1);

            Console.WriteLine("Valid Result: " + treeCount1);
            Console.WriteLine("Valid Result 2: " + treeCount2);
        }
    }
}