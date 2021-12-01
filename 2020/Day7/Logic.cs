using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day7
{
    public class Logic
    {
        private static Regex luggageRegex = new Regex(@"^(\d+) (\w+ \w+) (bags?\.?)$");
        public static KeyValuePair<string, List<Luggage>> ParseLine(string input)
        {
            string[] components = input.Split("bags contain");

            string key = components[0].Trim();
            List<Luggage> luggage;
            if (components[1].Contains("no other bags")) 
                luggage = new List<Luggage>();
            else
                luggage = components[1].Split(",").Select(ParseLuggage).ToList();
            return new KeyValuePair<string, List<Luggage>>(key, luggage);
        }


        public static Luggage ParseLuggage(string input)
        {
            Match match = luggageRegex.Match(input.Trim());
            return new Luggage(match.Groups[2].Value, int.Parse(match.Groups[1].Value));
        }

        private static bool EndsInGoalBag(string goalBagId, string startingRule,  Dictionary<string, List<Luggage>> 
        rules)
        {
            if (goalBagId == startingRule)
                return true;

            var rulesLuggage = rules[startingRule];

            return rulesLuggage.Any(nestedRule => EndsInGoalBag(goalBagId, nestedRule.Id, rules));
        }
        
        public static int Part1(string input, string goalBagId)
        {
            int count = 0;
            Dictionary<string, List<Luggage>> rules = input.Split("\n").Select(ParseLine).ToDictionary(t=> t.Key,t=> t.Value );

            foreach (var rule in rules)
            {
                if (rule.Key != goalBagId && EndsInGoalBag(goalBagId, rule.Key, rules))
                    count += 1;
            }

            return count;
        }

        private static int CountInternalBags(string bagId, Dictionary<string, List<Luggage>>
            rules)
        {
            var rulesLuggage = rules[bagId];
            return rulesLuggage.Count == 0
                ? 1
                : rulesLuggage.Select(x => x.Quantity * CountInternalBags(x.Id, rules)).Sum().Value + 1;
        }
        
        public static int Part2(string input, string startingBagId)
        {
            Dictionary<string, List<Luggage>> rules = input.Split("\n").Select(ParseLine).ToDictionary(t=> t.Key,t=> t.Value );

            return CountInternalBags("shiny gold", rules) - 1;
        }
    }
}