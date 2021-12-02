package Day1;

import java.util.Arrays;

public class Sonar {
    public Integer DepthIncreaseCount(Integer[] depths)  {
        int increases = 0;
        for (int i = 1; i < depths.length; i++) {
            if (depths[i-1] < depths[i]) {
                increases++;
            }
        }
        return increases;
    }

    public int MovingAverageDepthIncreaseCount(Integer[] depths) {
        return MovingAverageDepthIncreaseCount(depths, 3);
    }

    public int MovingAverageDepthIncreaseCount(Integer[] depths, int averageCount) {
        int increases = 0;

        for (int i = averageCount; i < depths.length; i++) {
            if (depths[i-averageCount] < depths[i]) {
                increases++;
            }
        }
        return increases;
    }
}
