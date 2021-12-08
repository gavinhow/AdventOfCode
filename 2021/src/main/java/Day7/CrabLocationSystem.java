package Day7;

import java.util.Arrays;

public class CrabLocationSystem {
    private final int[] locations;

    public CrabLocationSystem(int[] locations) {
        this.locations = locations;
    }

    public Integer calculateCost(Integer target) {
        return Arrays.stream(locations).map(x -> Math.abs(x - target)).sum();
    }

    public int calculateMinimum() {
        double median = median(locations);
        return calculateCost((int) median);
    }

    public Integer calculateCostPar2(Integer target) {
        return Arrays.stream(locations).map(x -> calculateNthTriangleNumber(Math.abs(x - target))).sum();
    }

    public Integer calculateNthTriangleNumber(int highestNumber ) {
        int total = 0;
        for (int i = highestNumber; i > 0; i--) {
            total += i;
        }
        return total;
    }

    public int calculateMinimumPart2() {
        double mean = findAverageUsingStream(locations);
        return calculateCostPar2((int) mean);
    }

    public static double findAverageUsingStream(int[] array) {
        return Arrays.stream(array).average().orElse(Double.NaN);
    }

    public static double median(int[] values) {
        // sort array
        Arrays.sort(values);
        double median;
        // get count of scores
        int totalElements = values.length;
        // check if total number of scores is even
        if (totalElements % 2 == 0) {
            int sumOfMiddleElements = values[totalElements / 2] +
                    values[totalElements / 2 - 1];
            // calculate average of middle elements
            median = ((double) sumOfMiddleElements) / 2;
        } else {
            // get the middle element
            median = (double) values[values.length / 2];
        }
        return median;
    }
}
