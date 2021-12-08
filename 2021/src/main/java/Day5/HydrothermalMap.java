package Day5;

import java.util.Arrays;
import java.util.List;

public class HydrothermalMap {

    public int[][] map;

    public HydrothermalMap() {
        this(999);
    }

    public HydrothermalMap(Integer size) {
        map = new int[size][size];
    }

    private boolean processInputStraight(Integer[] pos1, Integer[] pos2) {
        // X axis is the same
        if (pos1[0].equals(pos2[0])) {
            int smallNumber = pos1[1] < pos2[1] ? pos1[1] : pos2[1];
            int bigNumber = pos1[1] > pos2[1] ? pos1[1] : pos2[1];
            for (int i = smallNumber; i <= bigNumber; i++) {
                this.map[pos1[0]][i] += 1;
            }
            return true;
        }

        //Y axis the same
        if (pos1[1].equals(pos2[1])) {
            int smallNumber = pos1[0] < pos2[0] ? pos1[0] : pos2[0];
            int bigNumber = pos1[0] > pos2[0] ? pos1[0] : pos2[0];
            for (int i = smallNumber; i <= bigNumber; i++) {
                this.map[i][pos1[1]] += 1;
            }
            return true;
        }
        return false;
    }

    public void processInputPart1(String input) {
        List<String> inputs = Arrays.stream(input.split("->")).map(String::trim).toList();
        Integer[] pos1 = Arrays.stream(inputs.get(0).split(",")).map(Integer::parseInt).toArray(Integer[]::new);
        Integer[] pos2 = Arrays.stream(inputs.get(1).split(",")).map(Integer::parseInt).toArray(Integer[]::new);

        processInputStraight(pos1, pos2);
    }

    public void processInputPart2(String input) {
        List<String> inputs = Arrays.stream(input.split("->")).map(String::trim).toList();
        Integer[] pos1 = Arrays.stream(inputs.get(0).split(",")).map(Integer::parseInt).toArray(Integer[]::new);
        Integer[] pos2 = Arrays.stream(inputs.get(1).split(",")).map(Integer::parseInt).toArray(Integer[]::new);

        boolean isStraightLine = processInputStraight(pos1, pos2);

        // Diagonal line
        if (!isStraightLine) {
            boolean isXDecreasing = pos2[0] < pos1[0];
            boolean isYDecreasing = pos2[1] < pos1[1];
            int difference = Math.abs(pos1[0] - pos2[0]);
            for (int i = 0; i <= difference; i++) {
                int x = isXDecreasing ? pos1[0]-i :  pos1[0]+i;
                int y = isYDecreasing ? pos1[1]-i :  pos1[1]+i;
                this.map[y][x] += 1;
            }
        }
    }


    public int countOverlappingPoints() {
        return Arrays.stream(map).mapToInt(x-> (int) Arrays.stream(x).filter(y-> y>1).count()).sum();
    }

}
