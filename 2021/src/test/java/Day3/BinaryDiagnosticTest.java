package Day3;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class BinaryDiagnosticTest {

    @BeforeEach
    void setUp() {
    }

    @AfterEach
    void tearDown() {
    }

    @Test
    void gammaValueTest() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        String result = binaryDiagnostic.calculateGamma(input);

        assertEquals("10110", result);
    }

    @Test
    void epsilonValueTest() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        String result = binaryDiagnostic.calculateEpsilon(input);

        assertEquals("01001", result);
    }

    @Test
    void powerConsumption() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        Integer result = binaryDiagnostic.powerConsumption(input);

        assertEquals(198, result );
    }

    @Test
    void lifeSupportRating() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        Integer result = binaryDiagnostic.lifeSupportRating(input);

        assertEquals(230, result );
    }

    @Test
    void binaryToDecimal() {
        String input = "10110";

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        Integer result = binaryDiagnostic.convertBinaryToDecimal(input);

        assertEquals(22, result );
    }

    @Test
    void oxygenGeneratorRating() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        String result = binaryDiagnostic.oxygenGeneratorRating(input);

        assertEquals("10111", result );
    }

    @Test
    void co2ScrubberRating() {
        String[] input = {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

        BinaryDiagnostic binaryDiagnostic = new BinaryDiagnostic();
        String result = binaryDiagnostic.co2ScrubberRating(input);

        assertEquals("01010", result );
    }
}