package Day2;


import Day2.Models.Instruction;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.util.List;

public class Application {
    public static void main(String[] args) throws URISyntaxException {
        Application app = new Application();
        String fileName = "InputData/Day2/1.txt";
        File file = app.getFileFromResource(fileName);
        List<String> lines;
        try {
            lines = Files.readAllLines(file.toPath(), StandardCharsets.UTF_8);
            Instruction[] instructions = lines.stream().map(Instruction::parseInput).toArray(Instruction[]::new);

            RouteCalculator routeCalculator = new RouteCalculator();
            Integer finalPart1 = routeCalculator.calculateFinalOutputPart1(instructions);

            System.out.println("Part 1");
            System.out.println(finalPart1);


            Integer finalPart2 = routeCalculator.calculateFinalOutputPart2(instructions);

            System.out.println("Part 2");
            System.out.println(finalPart2);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    /*
        The resource URL is not working in the JAR
        If we try to access a file that is inside a JAR,
        It throws NoSuchFileException (linux), InvalidPathException (Windows)

        Resource URL Sample: file:java-io.jar!/json/file1.json
     */
    private File getFileFromResource(String fileName) throws URISyntaxException {
        ClassLoader classLoader = getClass().getClassLoader();
        URL resource = classLoader.getResource(fileName);
        if (resource == null) {
            throw new IllegalArgumentException("file not found! " + fileName);
        } else {

            // failed if files have whitespaces or special characters
            //return new File(resource.getFile());

            return new File(resource.toURI());
        }

    }

}
