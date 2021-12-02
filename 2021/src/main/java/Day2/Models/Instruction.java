package Day2.Models;

import java.util.Locale;

public class Instruction {
    public Command command;
    public Integer value;

    Instruction(Command command, Integer value) {
        this.command = command;
        this.value = value;
    }

    public static Instruction parseInput(String output) {
        String[] splitInput = output.split(" ");
        Command command = Command.valueOf(splitInput[0].toUpperCase(Locale.ROOT));
        Integer value = Integer.valueOf(splitInput[1]);

        return new Instruction(command, value);
    }
}
