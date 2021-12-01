using System;
using System.Numerics;

namespace Day3
{
    public class Logic
    {
        public static BigInteger TreeRoute(Map map, in int xDelta, in int yDelta)
        {
            int x = 0;
            int y = 0;
            int treeCount = 0;
            while (true)
            {
                try
                {
                    if (map.IsTree(x, y))
                        treeCount += 1;
                }
                catch (Exception e)
                {
                    return treeCount;
                }

                x += xDelta;
                y += yDelta;
            }
        }
    }
}