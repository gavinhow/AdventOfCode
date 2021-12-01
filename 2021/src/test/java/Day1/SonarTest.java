package Day1;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class SonarTest {

    Sonar sonar;

    @BeforeEach
    void setUp() {
        sonar = new Sonar();
    }

    @AfterEach
    void tearDown() {
    }

    @Test
    void depthIncreaseCount() {
        Integer[] testData = {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
        };
        assertEquals(7, sonar.DepthIncreaseCount(testData));
    }

    @Test
    void movingAverageDepthIncreaseCount() {
        Integer[] testData = {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
        };
        assertEquals(5, sonar.MovingAverageDepthIncreaseCount(testData));
    }
}