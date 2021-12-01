using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");


            List<string> passports = new List<string>();
            string tempPassport = "";
            foreach (string line in lines)
            {
                if (line == "")
                {
                    passports.Add(tempPassport);
                    tempPassport = "";
                }
                else
                {
                    tempPassport += line + " ";
                }
            }
            
            passports.Add(tempPassport);
            
            List<string> validPassports = new List<string>();

            int validCount = 0;
            foreach (string passport in passports)
            {
                if (Passport.IsValidPart1(passport))
                {              
                    validCount += 1;
                    validPassports.Add(passport);

                }
            }

            int validCountPart2 = 0;
            List<string> validPart2 = new List<string>();
            foreach (string passport in validPassports)
            {
                if (Passport.Parse(passport).IsValid())
                {
                    validCountPart2 += 1;
                    validPart2.Add(passport);
                }
            }

            Console.WriteLine($"Valid count : {validCount}");
            Console.WriteLine($"Valid count part 2: {validCountPart2}");
        }
    }
}