package Day2;


import Day2.Models.Instruction;
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
            List<String> lines = InputReader.LoadPuzzleData(2);
            Instruction[] instructions = lines.stream().map(Instruction::parseInput).toArray(Instruction[]::new);

            RouteCalculator routeCalculator = new RouteCalculator();
            Integer finalPart1 = routeCalculator.calculateFinalOutputPart1(instructions);

            System.out.println("Part 1");
            System.out.println(finalPart1);

            Integer finalPart2 = routeCalculator.calculateFinalOutputPart2(instructions);

            System.out.println("Part 2");
            System.out.println(finalPart2);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
