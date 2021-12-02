package Day1;

import Util.InputReader;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(1);
            Integer[] depths = lines.stream().map(Integer::valueOf).toArray(Integer[]::new);
            Sonar sonar = new Sonar();
            Integer depthIncreases = sonar.DepthIncreaseCount(depths);
            System.out.println("Part 1");
            System.out.println(depthIncreases);

            Integer averageDepthIncreases = sonar.MovingAverageDepthIncreaseCount(depths);
            System.out.println("Part 2");
            System.out.println(averageDepthIncreases);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
