namespace Day8
{
    public class State
    {
        public int Position    { get; set; }
        public int Accumulator { get; set; }

        public State()
        {
            Position = 0;
            Accumulator = 0;
        }
    }
}