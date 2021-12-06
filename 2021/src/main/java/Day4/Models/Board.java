package Day4.Models;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Board {

    List<List<Integer>> bingoRows;
    List<List<Integer>> bingoColumns;

    private Board(List<List<Integer>> bingoRows) {
        this.bingoRows = bingoRows;

    }

    private List<List<Integer>> convertRowsToColumns(List<List<Integer>> bingoRows) {
        int rowLength = bingoRows.get(0).size();
        for (int i = 0; i < rowLength; i++) {
            bingoRows.stream().forEach(x-> x.get(i));
        }
    }

    public static Board parseFromInput(String[] input) {
        List<List<Integer>> values = new ArrayList<>();
        String[] removedEmptyLines = Arrays.stream(input).filter(x-> x.trim().equals("")).toArray(String[]::new);
        for (String line :
                removedEmptyLines) {
            String[] bingoNumbers = line.split(" ");
            values.add(Arrays.stream(bingoNumbers).map(Integer::parseInt).toList());
        }

        return new Board(values);
    }

}
