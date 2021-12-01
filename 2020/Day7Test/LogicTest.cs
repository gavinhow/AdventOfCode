using System;
using System.Collections.Generic;
using Day7;
using Xunit;

namespace Day7Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData("light red bags contain 1 bright white bag, 2 muted yellow bags.", "light red")]
        public void ParseOneLineTest(string input, string key)
        {
            KeyValuePair<string, List<Luggage>> response = Logic.ParseLine(input);
            
            Assert.Equal(key, response.Key);
        }

        [Theory]
        [InlineData(" 2 muted yellow bags.", "muted yellow", 2)]
        [InlineData("1 bright white bag", "bright white", 1)]
        [InlineData("1 shiny gold bag.", "shiny gold", 1)]
        public void ParseLuggageSection(string input, string id, int quantity)
        {
            Luggage result = Logic.ParseLuggage(input);
            
            Assert.Equal(quantity, result.Quantity);
            Assert.Equal(id, result.Id);
        }

        [Fact]
        public void Part1Test()
        {
            string input =
                "light red bags contain 1 bright white bag, 2 muted yellow bags.\ndark orange bags contain 3 bright white bags, 4 muted yellow bags.\nbright white bags contain 1 shiny gold bag.\nmuted yellow bags contain 2 shiny gold bags, 9 faded blue bags.\nshiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.\ndark olive bags contain 3 faded blue bags, 4 dotted black bags.\nvibrant plum bags contain 5 faded blue bags, 6 dotted black bags.\nfaded blue bags contain no other bags.\ndotted black bags contain no other bags.";

            Assert.Equal(4, Logic.Part1(input, "shiny gold"));
        }
        
        [Theory]
        [InlineData(32, "light red bags contain 1 bright white bag, 2 muted yellow bags.\ndark orange bags contain 3 bright white bags, 4 muted yellow bags.\nbright white bags contain 1 shiny gold bag.\nmuted yellow bags contain 2 shiny gold bags, 9 faded blue bags.\nshiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.\ndark olive bags contain 3 faded blue bags, 4 dotted black bags.\nvibrant plum bags contain 5 faded blue bags, 6 dotted black bags.\nfaded blue bags contain no other bags.\ndotted black bags contain no other bags.")]
        [InlineData(126, "shiny gold bags contain 2 dark red bags.\ndark red bags contain 2 dark orange bags.\ndark orange bags contain 2 dark yellow bags.\ndark yellow bags contain 2 dark green bags.\ndark green bags contain 2 dark blue bags.\ndark blue bags contain 2 dark violet bags.\ndark violet bags contain no other bags.")]
        public void Part2Test(int result, string input)
        {
            Assert.Equal(result, Logic.Part2(input, "shiny gold"));
        }
    }
}