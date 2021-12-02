package Day2;

import Day2.Models.Instruction;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class RouteCalculatorTest {

    @Test
    void calculateFinalOutputPart1() {
        Instruction[] instructions = {
                Instruction.parseInput("forward 5"),
                Instruction.parseInput("down 5"),
                Instruction.parseInput("forward 8"),
                Instruction.parseInput("up 3"),
                Instruction.parseInput("down 8"),
                Instruction.parseInput("forward 2"),

        };

        RouteCalculator routeCalculator = new RouteCalculator();

        Integer result = routeCalculator.calculateFinalOutputPart1(instructions);

        assertEquals(150, result);
    }

    @Test
    void calculateFinalOutputPart2() {
        Instruction[] instructions = {
                Instruction.parseInput("forward 5"),
                Instruction.parseInput("down 5"),
                Instruction.parseInput("forward 8"),
                Instruction.parseInput("up 3"),
                Instruction.parseInput("down 8"),
                Instruction.parseInput("forward 2"),

        };

        RouteCalculator routeCalculator = new RouteCalculator();

        Integer result = routeCalculator.calculateFinalOutputPart2(instructions);

        assertEquals(900, result);
    }

    @Test
    void calculateTwoUsingSameClass() {
        Instruction[] instructions = {
                Instruction.parseInput("forward 5"),
                Instruction.parseInput("down 5"),
                Instruction.parseInput("forward 8"),
                Instruction.parseInput("up 3"),
                Instruction.parseInput("down 8"),
                Instruction.parseInput("forward 2"),

        };

        RouteCalculator routeCalculator = new RouteCalculator();

        Integer resultPart1 = routeCalculator.calculateFinalOutputPart1(instructions);
        Integer resultPart2 = routeCalculator.calculateFinalOutputPart2(instructions);

        assertEquals(150, resultPart1);
        assertEquals(900, resultPart2);
    }
}