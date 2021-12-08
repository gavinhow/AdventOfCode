package Day6;

import Util.InputReader;

import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(6);
            LaternfishEnvironment environment = LaternfishEnvironment.parseInput(lines.get(0));

            for (int i = 0; i < 80; i++) {
                environment.increment();
            }

            System.out.printf("Part 1: %s%n", environment.getPopulationSize());

            environment = LaternfishEnvironment.parseInput(lines.get(0));
            for (int i = 0; i < 256; i++) {
                environment.increment();
            }

            System.out.printf("Part 2: %s%n", environment.getPopulationSize());

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
