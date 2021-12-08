package Day5;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class HydrothermalMapTest {

    @Test
    void processInput() {
        HydrothermalMap map = new HydrothermalMap(10);
        map.processInputPart1("0,9 -> 5,9");

        assertEquals(1, map.map[0][9]);
        assertEquals(1, map.map[1][9]);
        assertEquals(1, map.map[2][9]);
        assertEquals(1, map.map[3][9]);
        assertEquals(1, map.map[4][9]);
        assertEquals(1, map.map[5][9]);
        assertEquals(0, map.map[6][9]);

        map.processInputPart1("0,9 -> 2,9");
        assertEquals(2, map.map[0][9]);
        assertEquals(2, map.map[1][9]);
        assertEquals(2, map.map[2][9]);
        assertEquals(1, map.map[3][9]);
        assertEquals(1, map.map[4][9]);
        assertEquals(1, map.map[5][9]);
        assertEquals(0, map.map[6][9]);
    }

    @Test
    void processInputPart2() {
        HydrothermalMap map = new HydrothermalMap(10);
        map.processInputPart2("0,9 -> 5,9");

        assertEquals(1, map.map[0][9]);
        assertEquals(1, map.map[1][9]);
        assertEquals(1, map.map[2][9]);
        assertEquals(1, map.map[3][9]);
        assertEquals(1, map.map[4][9]);
        assertEquals(1, map.map[5][9]);
        assertEquals(0, map.map[6][9]);

        map.processInputPart2("8,0 -> 0,8");
        assertEquals(1, map.map[8][0]);
        assertEquals(1, map.map[7][1]);
        assertEquals(1, map.map[6][2]);
        assertEquals(1, map.map[5][3]);
        assertEquals(1, map.map[4][4]);
        assertEquals(1, map.map[3][5]);
        assertEquals(1, map.map[2][6]);
        assertEquals(1, map.map[1][7]);
        assertEquals(1, map.map[0][8]);

        map.processInputPart2("8,0 -> 0,8");
        assertEquals(2, map.map[8][0]);
        assertEquals(2, map.map[7][1]);
        assertEquals(2, map.map[6][2]);
        assertEquals(2, map.map[5][3]);
        assertEquals(2, map.map[4][4]);
        assertEquals(2, map.map[3][5]);
        assertEquals(2, map.map[2][6]);
        assertEquals(2, map.map[1][7]);
        assertEquals(2, map.map[0][8]);
    }

    @Test
    void overlappingPoints() {
        HydrothermalMap map = new HydrothermalMap(10);
        map.processInputPart1("0,9 -> 5,9");
        map.processInputPart1("8,0 -> 0,8");
        map.processInputPart1("9,4 -> 3,4");
        map.processInputPart1("2,2 -> 2,1");
        map.processInputPart1("7,0 -> 7,4");
        map.processInputPart1("6,4 -> 2,0");
        map.processInputPart1("0,9 -> 2,9");
        map.processInputPart1("3,4 -> 1,4");
        map.processInputPart1("0,0 -> 8,8");
        map.processInputPart1("5,5 -> 8,2");

        assertEquals(5, map.countOverlappingPoints());
    }

    @Test
    void overlappingPointsDiagonal() {
        HydrothermalMap map = new HydrothermalMap(10);
        map.processInputPart2("0,9 -> 5,9");
        map.processInputPart2("8,0 -> 0,8");
        map.processInputPart2("9,4 -> 3,4");
        map.processInputPart2("2,2 -> 2,1");
        map.processInputPart2("7,0 -> 7,4");
        map.processInputPart2("6,4 -> 2,0");
        map.processInputPart2("0,9 -> 2,9");
        map.processInputPart2("3,4 -> 1,4");
        map.processInputPart2("0,0 -> 8,8");
        map.processInputPart2("5,5 -> 8,2");

        assertEquals(12, map.countOverlappingPoints());
    }
}