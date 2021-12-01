using System;
using System.Linq;
using System.Numerics;

namespace Day9
{
    public class Logic
    {
        public static long[] Parse(string input)
        {
            return input.Split('\n').Select(long.Parse).ToArray();
        }

        public static bool IsInPreambleSum(long[] preAmble, long target)
        {
            int lowerPointer = 0;
            int upperPointer = preAmble.Length - 1;
            long[] sortedArray= preAmble.OrderBy(i => i).ToArray();

            while (lowerPointer != upperPointer)
            {
                long sum = sortedArray[lowerPointer] + sortedArray[upperPointer];
                if (sum == target)
                    return true;
                else if (sum < target)
                    lowerPointer++;
                else if (sum > target)
                    upperPointer--;
            }

            return false;
        }

        public static long Part1(string input)
        {
            long[] inputArray = Parse(input);
            for (int i = 25; i < inputArray.Length; i++)
            {
                long[] preAmble = inputArray.Skip(i-25).Take(25).ToArray();
                long target = inputArray[i];
                if (!IsInPreambleSum(preAmble, target))
                    return target;
            }
            
            throw new Exception("End reached with no error");
        }
        
        public static long Part2(string input, long targetNumber)
        {
            long[] inputArray = Parse(input);
            int lowerPointer = 0;
            int upperPointer = 1;
            long sum = inputArray.Skip(lowerPointer).Take(upperPointer-lowerPointer).Sum();
            while (sum != targetNumber)
            {
                if (sum < targetNumber)
                    upperPointer++;
                if (sum > targetNumber)
                    lowerPointer++;
                sum = inputArray.Skip(lowerPointer).Take(upperPointer-lowerPointer).Sum();
            }

            long[] numbers = inputArray.Skip(lowerPointer).Take(upperPointer - lowerPointer).OrderBy(x=>x).ToArray();
            return numbers[0] + numbers[numbers.Length-1];
        }
    }
}