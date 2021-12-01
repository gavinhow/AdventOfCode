using System;
using System.Numerics;
using Day3;
using Xunit;

namespace Day3Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 0)]
        public void ParseMap(int x, int y)
        {
            string mapString =
                "..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#";

            string[] mapLines = mapString.Split("\n");

            Map map = Map.Parse(mapLines);

            Assert.True(map.IsTree(x, y));
        }

        [Theory]
        [InlineData(0, 13)]
        [InlineData(1, 11)]
        public void MapDuplicatesToRightTest(int x, int y)
        {
            string mapString =
                "..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#";

            string[] mapLines = mapString.Split("\n");

            Map map = Map.Parse(mapLines);

            Assert.True(map.IsTree(x, y));
        }

        [Theory]
        [InlineData(93, 13)]
        [InlineData(11, 11)]
        public void ReachedBottomOfMap(int x, int y)
        {
            string mapString =
                "..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#";

            string[] mapLines = mapString.Split("\n");

            Map map = Map.Parse(mapLines);

            Assert.Throws<Exception>(() => map.IsTree(x, y));
        }

        [Theory]
        [InlineData(1, 3, 7)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 5, 3)]
        [InlineData(1, 7, 4)]
        [InlineData(2, 1, 2)]
        public void TrogectoryTreeCount(int x, int y, int totalHits)
        {
            string mapString =
                "..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#";

            string[] mapLines = mapString.Split("\n");

            Map map = Map.Parse(mapLines);

            BigInteger result = Logic.TreeRoute(map, x, y);

            Assert.Equal(totalHits, result);
        }
    }
}