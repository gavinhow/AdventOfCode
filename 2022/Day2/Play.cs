namespace Day2;

public class Play: IComparable
{
    public RockPaperScissors RockPaperScissors { get; set; }

    public int CompareTo(object? incomingobject)
    {
        // Storing incoming object in temp variable of 
        // current class type
        Play incomingPlay = incomingobject as Play ?? throw new InvalidOperationException();

        if (this.RockPaperScissors == RockPaperScissors.Scissors &&
            incomingPlay.RockPaperScissors == RockPaperScissors.Rock)
        {
            return -1;
        }
        
        if (this.RockPaperScissors == RockPaperScissors.Rock &&
            incomingPlay.RockPaperScissors == RockPaperScissors.Scissors)
        {
            return 1;
        }
        
        return this.RockPaperScissors.CompareTo(incomingPlay.RockPaperScissors);
    }
}