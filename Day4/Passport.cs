using System.Linq;

namespace Day4
{
    public class Passport
    {

        private static readonly string[] requiredTags = {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};

        public static bool IsValid(string passport)
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
    }
}