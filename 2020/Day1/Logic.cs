using System;
using System.Collections.Generic;

namespace Day1
{
    public class Logic
    {
        
        public static bool IsTwentyTwentyPair(in int a, in int b)
        {
            return a + b == 2020;
        }

        public static KeyValuePair<int, int> Find2020Pair(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Need more than two numbers in array");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;

                    int secondNumber = numbers[j];

                    if (IsTwentyTwentyPair(firstNumber, secondNumber))
                        return new KeyValuePair<int, int>(firstNumber, secondNumber);
                }
            }
            
            throw new Exception("No numbers sum to 2020");
        }
        
        public static int[] Find2020Trio(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                throw new ArgumentException("Need more than three numbers in array");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;

                    int secondNumber = numbers[j];

                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (k == j)
                            continue;

                        int thirdNumber = numbers[k];

                        if (IsTwentyTwentyTrio(firstNumber, secondNumber, thirdNumber))
                            return new int[] {firstNumber, secondNumber, thirdNumber};
                    }
                }
            }
            
            throw new Exception("No numbers sum to 2020");
        }
        
        public static List<int> Find2020V2(List<int> numbers, int desiredSum, int numberOfElements)
        {
            if (numbers.Count < numberOfElements)
                throw new ArgumentException("Need more numbers than desired number of elements");

            if (numberOfElements == 0 && desiredSum == 0)
                return numbers;
            
            if (desiredSum < 0)
                throw new Exception("Invalid Path");
            
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                var newList = numbers;
                newList.RemoveAt(i);
                Find2020V2(newList, desiredSum - number, numberOfElements - 1);
            }
            
            throw new Exception("No numbers sum to 2020");
        }

        public static bool IsTwentyTwentyTrio(in int a, in int b, in int c)
        {
            return a + b + c == 2020;
        }
    }
}