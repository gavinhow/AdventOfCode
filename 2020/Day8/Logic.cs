using System;
using System.Linq;
using System.Security;

namespace Day8
{
    public class Logic
    {
        public static Instruction[] ParseInstructionSet(string input)
        {
            return input.Split('\n').Select(Instruction.Parse).ToArray();
        }

        public static int Part1(string input)
        {
            Instruction[] instructions = ParseInstructionSet(input);
            State state = new State();

            int accumulatorEndValue;
            try
            {
                while (true)
                {
                    state = instructions[state.Position].Execute(state);
                }
            }
            catch (Exception e)
            {
                accumulatorEndValue = state.Accumulator;
            }

            return accumulatorEndValue;
        }
        
        public static int Part2(string input)
        {
            
            for (int i = 0; i < ParseInstructionSet(input).Length; i++)
            {
                try
                {
                    Instruction[] instructions = ParseInstructionSet(input);

                    return Part2Nest(instructions, i);
                }
                catch (Exception e)
                {
                    // ignore
                }
            }

            throw new Exception("Didn't complete correctly.");
        }

        public static int Part2Nest(Instruction[] instructions, int positionToChange)
        {
            State state = new State();

            if (instructions[positionToChange].Operation == OperationType.JMP)
                instructions[positionToChange].Operation = OperationType.NOP;
            else if (instructions[positionToChange].Operation == OperationType.NOP)
                instructions[positionToChange].Operation = OperationType.JMP;
            else
                throw new Exception("Not a JMP or NOP position");

            while (true)
            {
                if (state.Position == instructions.Length)
                    return state.Accumulator;
                
                state = instructions[state.Position].Execute(state);
            }
        }
    }
}