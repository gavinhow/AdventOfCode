namespace Day2;

public class OpponentPlay : Play
{
    public static readonly OpponentPlay A = new OpponentPlay(RockPaperScissors.Rock);
    public static readonly OpponentPlay B = new OpponentPlay(RockPaperScissors.Paper);
    public static readonly OpponentPlay C = new OpponentPlay(RockPaperScissors.Scissors);


    public OpponentPlay(RockPaperScissors rockPaperScissors)
    {
        this.RockPaperScissors = rockPaperScissors;
    }
    
    public static OpponentPlay parse(string letter)
    {
        switch (letter)
        {
            case "A":
                return A;
            case "B":
                return B;
            case "C":
                return C;
        }

        throw new ArgumentException();
    }
}