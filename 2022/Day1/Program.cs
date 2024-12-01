using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = System.IO.File.ReadAllText(@"input.txt");
            
            
            Console.WriteLine("Highest Calorie Count: " + Logic.GetHighestCalories(lines));
            Console.WriteLine("Three Highest Calorie Count: " + Logic.GetThreeHighestCaloriesSum(lines));
        }
    }
}