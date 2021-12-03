package Day3;

import java.util.Arrays;
import java.util.List;

public class BinaryDiagnostic {
    public String calculateGamma(String[] input) {
        // Assuming all values have the same input length
        int inputValuesLength = input[0].length();

        StringBuilder outputBinary = new StringBuilder();
        for (int i = 0; i < inputValuesLength; i++) {
            outputBinary.append(calculateMostCommonValue(input, i));
        }

        return outputBinary.toString();
    }

    public Integer powerConsumption(String[] input) {
        String epsilonBinary = this.calculateEpsilon(input);
        String gammaBinary = this.calculateGamma(input);

        return this.convertBinaryToDecimal(epsilonBinary) * this.convertBinaryToDecimal(gammaBinary);
    }

    public String calculateEpsilon(String[] input) {
        // Assuming all values have the same input length
        int inputValuesLength = input[0].length();

        StringBuilder outputBinary = new StringBuilder();
        for (int i = 0; i < inputValuesLength; i++) {
            outputBinary.append(calculateLeastCommonValue(input, i));
        }

        return outputBinary.toString();
    }

    public Integer convertBinaryToDecimal(String binaryString) {
        return Integer.parseInt(binaryString,2);
    }

    public String oxygenGeneratorRating(String[] input) {
        Integer bitCount = 0;
        List<String> remainingBinaryValues = Arrays.stream(input).toList();

        while (remainingBinaryValues.size() > 1) {
            Character mostCommonValue = calculateMostCommonValue(remainingBinaryValues.toArray(String[]::new), bitCount);
            Integer finalBitCount = bitCount;
            remainingBinaryValues = remainingBinaryValues.stream().filter(value -> value.charAt(finalBitCount) == mostCommonValue).toList();
            bitCount++;
        }

        return remainingBinaryValues.get(0);
    }

    public String co2ScrubberRating(String[] input) {
        Integer bitCount = 0;
        List<String> remainingBinaryValues = Arrays.stream(input).toList();

        while (remainingBinaryValues.size() > 1) {
            Character leastCommonValue = calculateLeastCommonValue(remainingBinaryValues.toArray(String[]::new), bitCount);
            Integer finalBitCount = bitCount;
            remainingBinaryValues = remainingBinaryValues.stream().filter(value -> value.charAt(finalBitCount) == leastCommonValue).toList();
            bitCount++;
        }

        return remainingBinaryValues.get(0);
    }

    public Integer lifeSupportRating(String[] input) {
        String co2ScrubberRating = this.co2ScrubberRating(input);
        String oxygenGeneratorRating = this.oxygenGeneratorRating(input);

        return this.convertBinaryToDecimal(oxygenGeneratorRating) * this.convertBinaryToDecimal(co2ScrubberRating);
    }

    private Character calculateMostCommonValue(String[] binaryValues, Integer digit) {
        List<Character> values = Arrays.stream(binaryValues).map(value -> value.charAt(digit)).toList();
        float countOfOnes = values.stream().filter(x-> x=='1').count();
        boolean isOneMostCommon =  countOfOnes >= ((float) values.size() /2);
        return isOneMostCommon ? '1' : '0';
    }

    private Character calculateLeastCommonValue(String[] binaryValues, Integer digit) {
        List<Character> values = Arrays.stream(binaryValues).map(value -> value.charAt(digit)).toList();
        float countOfOnes = values.stream().filter(x-> x=='1').count();
        boolean isOneLeastCommon = countOfOnes < ((float) values.size() /2);
        return isOneLeastCommon ? '1' : '0';
    }
}
