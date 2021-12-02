package Day2;

import Day2.Models.Instruction;

public class RouteCalculator {
    Integer aim = 0;
    Integer depth = 0;
    Integer horizontalPosition = 0;

    public Integer calculateFinalOutputPart1(Instruction[] instructions) {
        resetClassVariables();
        for (Instruction instruction : instructions) {
            switch (instruction.command) {
                case UP -> depth -= instruction.value;
                case DOWN -> depth += instruction.value;
                case FORWARD -> horizontalPosition += instruction.value;
            }
        }

        return depth * horizontalPosition;
    }

    private void resetClassVariables() {
        aim = 0;
        depth = 0;
        horizontalPosition = 0;
    }

    public Integer calculateFinalOutputPart2(Instruction[] instructions) {
        resetClassVariables();
        for (Instruction instruction : instructions) {
            switch (instruction.command) {
                case UP -> aim -= instruction.value;
                case DOWN -> aim += instruction.value;
                case FORWARD -> processForwardValue(instruction.value);
            }
        }

        return depth * horizontalPosition;
    }

    private void processForwardValue(Integer value) {
        horizontalPosition+= value;
        depth += (value * aim);

        if (depth< 0) {
            depth = 0;
        }
    }
}
