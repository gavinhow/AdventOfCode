package Day6;

import Day6.Models.Laternfish;

import java.math.BigInteger;
import java.util.*;
import java.util.stream.Collectors;

public class LaternfishEnvironment {
    private final Integer NEW_FISH_AGE = 8;
    Map<Integer, Long> populationCountByAge;


    public BigInteger getPopulationSize () {
        BigInteger total = BigInteger.ZERO;
        for (int i = 0; i <= NEW_FISH_AGE; i++) {
            total = total.add(BigInteger.valueOf(populationCountByAge.get(i)));
        }

        return total;
    }

    public LaternfishEnvironment(List<Integer> population) {
        populationCountByAge = new HashMap<>();
        for (int i = 0; i <= NEW_FISH_AGE; i++) {
            int finalI = i;
            populationCountByAge.put(i, population.stream().filter(x-> x== finalI).count());
        }

    }

    public void increment() {
        Long newFishToMake = populationCountByAge.get(0);
        populationCountByAge.put(7, populationCountByAge.get(7) + newFishToMake);
        for (int i = 1; i <= NEW_FISH_AGE; i++) {
            populationCountByAge.put(i-1, populationCountByAge.get(i));
        }

        populationCountByAge.put(NEW_FISH_AGE, newFishToMake);
    }

    public static LaternfishEnvironment parseInput(String input) {
        List<Integer> laternfish = Arrays.stream(input.split(",")).map(Integer::parseInt).collect(Collectors.toList());
        return new LaternfishEnvironment(laternfish);
    }
}
