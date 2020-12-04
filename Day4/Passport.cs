using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    public class Passport
    {
        public int byr { get; private set; }
        public int iyr { get; private set; }
        public int eyr { get; private set; }
        public string hgt { get; private set; }
        public string hcl { get; private set; }
        public string ecl { get; private set; }
        public string pid { get; private set; }
        
        private static readonly string[] requiredTags = {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
        private static readonly string[] validEcl = {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};

        public static bool IsValidPart1(string passport)
        {
            string[] components = passport.Replace('\n', ' ').Split(' ');
            string[] tags = components.Select(x => x.Split(':')[0]).ToArray();

            foreach (string tag in requiredTags)
            {
                if (!tags.Contains(tag))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsValid()
        {
            if (byr == null || iyr == null || eyr == null || hgt == null || hcl == null || ecl == null || pid == null)
                return false;
            
            if (!IsByrValid(byr))
                return false;
            
            if (!IsIyrValid(iyr))
                return false;
            
            if (!IsEyrValid(eyr))
                return false;
            
            if (!IsHeightValid(hgt))
                return false;

            if (!IsHclValid(hcl))
                return false;

            if (!IsEclValid(ecl))
                return false;

            if (!IsPidValid(pid))
                return false;

            return true;
        }

        public static bool IsByrValid(int byr)
        {
            return byr >= 1920 && byr <= 2002;
        }

        public static bool IsIyrValid(int iyr)
        {
            return iyr >= 2010 && iyr <= 2020;
        }

        public static bool IsEyrValid(int eyr)
        {
            return eyr >= 2020 && eyr <= 2030;
        }

        public static bool IsHclValid(string hcl)
        {
            return Regex.IsMatch(hcl, "^#[0-9a-fA-F]{6}$");
        }

        public static bool IsEclValid(string ecl)
        {
            return validEcl.Contains(ecl);
        }

        public static bool IsPidValid(string pid)
        {
            return Regex.IsMatch(pid, "^[0-9]{9}$");
        }

        public static bool IsHeightValid(string hgt)
        {
            if (hgt == null)
                return false;
            int tmpHgt;
            if (!int.TryParse(hgt.Substring(0, hgt.Length - 2), out tmpHgt))
                return false;
            
            if (hgt.EndsWith("in") && (tmpHgt >= 59 && tmpHgt <= 76))
                return true;
            if (hgt.EndsWith("cm") && (tmpHgt >= 150 && tmpHgt <= 193))
                return true;

            return false;
        }

        public static Passport Parse(string passport)
        {
            Passport result = new Passport();
            string[] components = passport.Replace('\n', ' ').Split(' ');
            foreach (string component in components)
            {
                string[] split = component.Split(':');
                switch (split[0])
                {
                    case "byr":
                        result.byr = int.Parse(split[1]);
                        break;
                    case "iyr":
                        result.iyr = int.Parse(split[1]);
                        break;
                    case "eyr":
                        result.eyr = int.Parse(split[1]);
                        break;
                    case "hgt":
                        result.hgt = split[1];
                        break;
                    case "hcl":
                        result.hcl = split[1];
                        break;
                    case "ecl":
                        result.ecl = split[1];
                        break;
                    case "pid":
                        result.pid = split[1];
                        break;
                }
            }

            return result;
        }
    }
}