using System;
using System.Linq;

namespace Day3
{
    public class Map
    {
        private int width;
        private char[][] map;
        public static Map Parse(string[] mapLines)
        {
            Map map = new Map();
            map.map = mapLines.Select(x => x.ToCharArray()).ToArray();
            map.width = mapLines[0].Length;
            return map;
        }

        public bool IsTree(int x, int y)
        {
            if (x >= map.Length) 
                throw new Exception("Out of map");
            if (y >= width)
                y %= width;
            return map[x][y].Equals('#');
        }
    }
}