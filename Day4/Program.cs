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

            int validCount = 0;
            foreach (string passport in passports)
            {
                if (Passport.IsValid(passport))
                    validCount += 1;
            }

            Console.WriteLine($"Valid count : {validCount}");
        }
    }
}