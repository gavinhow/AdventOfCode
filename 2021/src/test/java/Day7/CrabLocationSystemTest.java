package Day7;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class CrabLocationSystemTest {
    CrabLocationSystem crabLocationSystem;

    @BeforeEach
    void setUp() {
        crabLocationSystem = new CrabLocationSystem(new int[] {16,1,2,0,4,2,7,1,2,14});
    }

    @AfterEach
    void tearDown() {
    }

    @Test
    void calculateCost2() {
        assertEquals(37, crabLocationSystem.calculateCost(2));
    }

    @Test
    void calculateCost1() {
        assertEquals(41, crabLocationSystem.calculateCost(1));
    }

    @Test
    void calculateCost3() {
        assertEquals(39, crabLocationSystem.calculateCost(3));
    }

    @Test
    void calculateCost10() {
        assertEquals(71, crabLocationSystem.calculateCost(10));
    }

    @Test
    void calculatingMinimum() {
        assertEquals(37, crabLocationSystem.calculateMinimum());
    }
}