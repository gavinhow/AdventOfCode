package Day2.Models;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class InstructionTest {

    @Test
    void parseForwardInput() {
        String input = "forward 5";

        Instruction instruction = Instruction.parseInput(input);

        assertEquals(5, instruction.value);
        assertEquals(Command.FORWARD, instruction.command);
    }

    @Test
    void parseDownInput() {
        String input = "down 5";

        Instruction instruction = Instruction.parseInput(input);

        assertEquals(5, instruction.value);
        assertEquals(Command.DOWN, instruction.command);
    }

    @Test
    void parseUpInput() {
        String input = "up 3";

        Instruction instruction = Instruction.parseInput(input);

        assertEquals(3, instruction.value);
        assertEquals(Command.UP, instruction.command);
    }
}