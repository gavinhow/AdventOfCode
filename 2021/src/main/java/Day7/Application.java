package Day7;

import Util.InputReader;

import java.util.Arrays;
import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(7);
            int[] locations = Arrays.stream(lines.get(0).split(",")).mapToInt(Integer::parseInt).toArray();

            CrabLocationSystem crabLocationSystem = new CrabLocationSystem(locations);
            System.out.printf("Part 1: %s%n", crabLocationSystem.calculateMinimum());

             crabLocationSystem = new CrabLocationSystem(locations);
            System.out.printf("Part 2: %s%n", crabLocationSystem.calculateMinimumPart2());


        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
