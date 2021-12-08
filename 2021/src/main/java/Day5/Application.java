package Day5;

import Util.InputReader;

import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(5);
            HydrothermalMap map = new HydrothermalMap();

            for (String line :
                    lines) {
                map.processInputPart1(line);
            }
            System.out.printf("Part 1: %s%n", map.countOverlappingPoints());

            map = new HydrothermalMap();
            for (String line :
                    lines) {
                map.processInputPart2(line);
            }

            System.out.printf("Part 2: %s%n", map.countOverlappingPoints());

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
