package Day3;

import Day2.Models.Instruction;
import Day2.RouteCalculator;
import Util.InputReader;

import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(3);
            String[] instructions = lines.stream().toArray(String[]::new);

            BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
            Integer finalPart1 = binaryDiagnostic.powerConsumption(instructions);

            System.out.println("Part 1");
            System.out.println(finalPart1);

            Integer finalPart2 = binaryDiagnostic.lifeSupportRating(instructions);

            System.out.println("Part 2");
            System.out.println(finalPart2);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
