using System;
using Day8;
using Xunit;

namespace Day8Test
{
    public class LogicTest
    {
        [Theory]
        [InlineData("nop +0", 0, OperationType.NOP)]
        [InlineData("acc +1", 1, OperationType.ACC)]
        [InlineData("acc -99", -99, OperationType.ACC)]
        [InlineData("jmp +44", 44, OperationType.JMP)]
        public void InstructionParse(string input, int argument, OperationType type)
        {
            Instruction result = Instruction.Parse(input);

            Assert.Equal(argument, result.Argument);
            Assert.Equal(type, result.Operation);
        }

        [Fact]
        public void InstructionSetParse()
        {
            string input = "nop +0\nacc +1\njmp +4\nacc +3\njmp -3\nacc -99\nacc +1\njmp -4\nacc +6";
            Instruction[] result = Logic.ParseInstructionSet(input);

            Assert.Equal(9, result.Length);
            Assert.Equal(OperationType.JMP, result[2].Operation);
        }

        [Theory]
        [InlineData(0, OperationType.NOP, 0, 1, 0, 0)]
        [InlineData(4, OperationType.ACC, 0, 1, 0, 4)]
        [InlineData(4, OperationType.ACC, 1, 2, 4, 8)]
        [InlineData(-4, OperationType.ACC, 1, 2, 8, 4)]
        [InlineData(4, OperationType.JMP, 1, 5, 4, 4)]
        [InlineData(-4, OperationType.JMP, 5, 1, 4, 4)]
        public void InstructionExecute(int argument, OperationType type, int startPosition, int endPosition,
            int startAccumulator, int
                accumulator)
        {
            State state = new State()
            {
                Accumulator = startAccumulator,
                Position = startPosition
            };
            Instruction instruction = new Instruction()
            {
                Operation = type, Argument = argument
            };

            state = instruction.Execute(state);

            Assert.Equal(endPosition, state.Position);
            Assert.Equal(accumulator, state.Accumulator);
        }

        [Fact]
        public void InstructionExecuteTwiceThrows()
        {
            State state = new State
            {
                Accumulator = 0,
                Position = 0
            };
            Instruction instruction = new Instruction()
            {
                Operation = OperationType.JMP, Argument = 4
            };

            state = instruction.Execute(state);

            Assert.Throws<Exception>(() => { instruction.Execute(state); });
        }
    }
}