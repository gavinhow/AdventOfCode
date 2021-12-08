package Day4.Models;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class BoardTest {

    @BeforeEach
    void setUp() {
    }

    @AfterEach
    void tearDown() {
    }

    @Test
    void parseFromInputCheckRow() {
        String[] input = new String[]{
                "22 13 17 11  0",
                " 8  2 23  4 24",
                "21  9 14 16  7",
                " 6 10  3 18  5",
                " 1 12 20 15 19"
        };

        Board board = Board.parseFromInput(input);

        assertFalse(board.processNumber(22));
        assertFalse(board.processNumber(13));
        assertFalse(board.processNumber(17));
        assertFalse(board.processNumber(11));
        assertFalse(board.processNumber(8));
        assertTrue(board.processNumber(0));
    }

    @Test
    void calculateScore() {
        String[] input = new String[]{
                "14 21 17 24  4",
                "10 16 15  9 19",
                "18  8 23 26 20",
                "22 11 13  6  5",
                " 2  0 12  3  7"
        };

        Board board = Board.parseFromInput(input);

        assertFalse(board.processNumber(7));
        assertFalse(board.processNumber(4));
        assertFalse(board.processNumber(9));
        assertFalse(board.processNumber(5));
        assertFalse(board.processNumber(11));
        assertFalse(board.processNumber(17));
        assertFalse(board.processNumber(23));
        assertFalse(board.processNumber(2));
        assertFalse(board.processNumber(0));
        assertFalse(board.processNumber(14));
        assertFalse(board.processNumber(21));
        assertTrue(board.processNumber(24));


        assertEquals(4512, board.calculateScore(24));

    }

    @Test
    void parseFromInputCheckColumn() {
        String[] input = new String[]{
                "22 13 17 11  0",
                " 8  2 23  4 24",
                "21  9 14 16  7",
                " 6 10  3 18  5",
                " 1 12 20 15 19"
        };

        Board board = Board.parseFromInput(input);

        assertFalse(board.processNumber(22));
        assertFalse(board.processNumber(8));
        assertFalse(board.processNumber(21));
        assertFalse(board.processNumber(11));
        assertFalse(board.processNumber(6));
        assertTrue(board.processNumber(1));
    }

    @Test
    void isListComplete() {
        List<Integer> row = Arrays.stream(new Integer[]{22, 13, 17, 11, 0}).toList();
        List<Integer> validNumbers = Arrays.stream(new Integer[]{22, 13, 17, 11, 0, 5, 10}).toList();

        assertTrue(Board.isListComplete(row, validNumbers));
    }

    @Test
    void isListCompleteReturnsFalse() {
        List<Integer> row = Arrays.stream(new Integer[]{22, 13, 17, 11, 0}).toList();
        List<Integer> validNumbers = Arrays.stream(new Integer[]{22, 5, 10}).toList();

        assertFalse(Board.isListComplete(row, validNumbers));
    }
}