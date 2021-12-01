using System;

namespace Day8
{
    public class Instruction
    {
        public OperationType Operation;
        public int Argument;
        private bool hasBeenExecuted;

        public static Instruction Parse(string input)
        {
            string[] components = input.Split(' ');
            return new Instruction()
            {
                Operation = (OperationType) Enum.Parse(typeof(OperationType), components[0], true),
                Argument = int.Parse(components[1])
            };
        }

        public State Execute(State currentState)
        {
            if (hasBeenExecuted)
                throw new Exception("Instruction has already been executed");

            hasBeenExecuted = true;
            switch (Operation)
            {
                case OperationType.NOP:
                    currentState.Position++;
                    return currentState;
                case OperationType.ACC:
                    currentState.Accumulator += Argument;
                    currentState.Position++;
                    return currentState;
                case OperationType.JMP:
                    currentState.Position += Argument;
                    return currentState;
                default:
                    return currentState;
            }
        }
    }
}