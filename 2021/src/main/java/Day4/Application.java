package Day4;

import Day4.Models.Board;
import Util.InputReader;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Application {
    public static void main(String[] args) {
        try {
            List<String> lines = InputReader.LoadPuzzleData(4);
            List<Integer> bingoNumbers = Arrays.stream(lines.get(0).split(",")).map(Integer::parseInt).toList();
            List<Board> boards = new ArrayList<>();
            for (int i = 2; i < lines.size(); i+=6) {
                List<String> boardInput = lines.subList(i, i+5);
                boards.add(Board.parseFromInput(boardInput.toArray(String[]::new)));
            }

            runPart1(boards, bingoNumbers);
            runPart2(boards, bingoNumbers);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void runPart1(List<Board> boards, List<Integer> bingoNumbers) {
        for (Integer bingoNumber :
                bingoNumbers) {
            for (Board board :
                    boards) {
                if (board.processNumber(bingoNumber)) {
                    System.out.println("Part 1 Finished");
                    System.out.printf("Result :%s%n", board.calculateScore(bingoNumber));
                    return;
                }
            }

        }
    }

    public static void runPart2(List<Board> boards, List<Integer> bingoNumbers) {
        Integer finalScore = 0;

        for (Integer bingoNumber :
                bingoNumbers) {
            for (Board board :
                    boards) {
                if (board.processNumber(bingoNumber)) {
                    finalScore = board.calculateScore(bingoNumber);
                }
            }

        }

        System.out.println("Part 2 Finished");
        System.out.printf("Result :%s%n", finalScore);

    }
}
