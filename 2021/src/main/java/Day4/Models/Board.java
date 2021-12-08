package Day4.Models;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Board {

    List<List<Integer>> bingoRows;
    List<List<Integer>> bingoColumns;

    boolean hasWon = false;

    List<Integer> validNumbers;

    private Board(List<List<Integer>> bingoRows) {
        this.bingoRows = bingoRows;
        this.bingoColumns = this.convertRowsToColumns(bingoRows);
        this.validNumbers = new ArrayList<>();
    }

    private List<List<Integer>> convertRowsToColumns(List<List<Integer>> bingoRows) {
        List<List<Integer>> columns = new ArrayList<>();
        int rowLength = bingoRows.get(0).size();
        for (int i = 0; i < rowLength; i++) {
            int finalI = i;
            List<Integer> column = bingoRows.stream().map(x-> x.get(finalI)).toList();
            columns.add(column);
        }

        return columns;
    }

    public boolean processNumber(Integer number) {
        if (hasWon){
            return false;
        }
        boolean isValidNumber = this.bingoRows.stream().anyMatch(x -> x.contains(number));
        if( isValidNumber ) {
            validNumbers.add(number);
            hasWon = this.bingoRows.stream().anyMatch(x-> isListComplete(x, this.validNumbers))
                    ||  this.bingoColumns.stream().anyMatch(x-> isListComplete(x, this.validNumbers));
            return hasWon;
        }

        return false;
    }

    public Integer calculateScore(Integer number) {
        List<Integer> allNumbers = bingoRows.stream()
                .collect(ArrayList::new, List::addAll, List::addAll);

        Integer sumOfUnpickedNumbers = allNumbers.stream().filter(x-> !this.validNumbers.contains(x)).reduce(0, Integer::sum);

        return sumOfUnpickedNumbers * number;
    }

    public static boolean isListComplete(List<Integer> row, List<Integer> validNumbers) {
        return validNumbers.containsAll(row);
    }

    public static Board parseFromInput(String[] input) {
        List<List<Integer>> values = new ArrayList<>();
        String[] removedEmptyLines = Arrays.stream(input).filter(x-> !x.trim().equals("")).toArray(String[]::new);
        for (String line :
                removedEmptyLines) {
            String[] bingoNumbers = Arrays.stream(line.split(" ")).filter(x-> !x.equals("")).toArray(String[]::new);
            values.add(Arrays.stream(bingoNumbers).map(Integer::parseInt).toList());
        }

        return new Board(values);
    }

}
