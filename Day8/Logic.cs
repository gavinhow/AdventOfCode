using System;
using System.Linq;

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
                    if (state.Position > 630)
                    {
                        Console.WriteLine("Test");
                    }
                    state = instructions[state.Position].Execute(state);
                    
                }
            }
            catch (Exception e)
            {
                accumulatorEndValue = state.Accumulator;
            }

            return accumulatorEndValue;
        }
        
        public static int Part2(string input, )
        {
            Instruction[] instructions = ParseInstructionSet(input);
            State state = new State();

            int accumulatorEndValue;
            try
            {
                while (true)
                {
                    if (state.Position >= instructions.Length)
                    {
                        return state.Accumulator;
                    }
                    state = instructions[state.Position].Execute(state);
                    
                }
            }
            catch (Exception e)
            {
                accumulatorEndValue = state.Accumulator;
            }

            return accumulatorEndValue;
        }
    }
}