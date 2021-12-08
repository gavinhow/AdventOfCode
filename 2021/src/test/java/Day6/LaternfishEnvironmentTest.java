package Day6;

import Day6.Models.Laternfish;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.math.BigInteger;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

import static org.junit.jupiter.api.Assertions.*;

class LaternfishEnvironmentTest {

    LaternfishEnvironment environment;

    @BeforeEach
    void setUp() {
        environment = new LaternfishEnvironment(Arrays.stream(new Integer[] {3,4,3,1,2}).collect(Collectors.toList()));
    }

    @AfterEach
    void tearDown() {
        environment = null;
    }

    @Test
    void getPopulationSize() {
        assertEquals(BigInteger.valueOf(5), environment.getPopulationSize());
    }

    @Test
    void increment() {
        environment.increment();

        assertEquals(BigInteger.valueOf(5), environment.getPopulationSize());


        environment.increment();

        assertEquals(BigInteger.valueOf(6), environment.getPopulationSize());

    }

    @Test
    void increment80() {
        for (int i = 0; i < 80; i++) {
            environment.increment();
        }

        assertEquals("5934", environment.getPopulationSize().toString());
    }

    @Test
    void increment256() {
        for (int i = 0; i < 256; i++) {
            environment.increment();
        }

        assertEquals("26984457539", environment.getPopulationSize().toString());
    }

    @Test
    void parse() {
        String input = "3,4,3,1,2";
        LaternfishEnvironment environment = LaternfishEnvironment.parseInput(input);
        assertEquals(BigInteger.valueOf(5), environment.getPopulationSize());

    }
}