package Util;

import Day1.Sonar;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.text.MessageFormat;
import java.util.List;

public class InputReader {

    public static List<String> LoadPuzzleData(Integer day) throws Exception {
        String fileName = MessageFormat.format("InputData/Day{0}/1.txt", day);
        File file = InputReader.getFileFromResource(fileName);

        try {
            return Files.readAllLines(file.toPath(), StandardCharsets.UTF_8);
        } catch (IOException e) {
            e.printStackTrace();
        }

        throw new Exception("Something gone wrong");
    }

    /*
        The resource URL is not working in the JAR
        If we try to access a file that is inside a JAR,
        It throws NoSuchFileException (linux), InvalidPathException (Windows)

        Resource URL Sample: file:java-io.jar!/json/file1.json
     */
    private static File getFileFromResource(String fileName) throws URISyntaxException {
        ClassLoader classLoader = InputReader.class.getClassLoader();
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
