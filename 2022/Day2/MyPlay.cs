namespace Day2;

public class MyPlay : Play
{
    public static readonly MyPlay X = new MyPlay(RockPaperScissors.Rock);
    public static readonly MyPlay Y = new MyPlay(RockPaperScissors.Paper);
    public static readonly MyPlay Z = new MyPlay(RockPaperScissors.Scissors);


    public MyPlay(RockPaperScissors rockPaperScissors)
    {
        this.RockPaperScissors = rockPaperScissors;
    }

    public static MyPlay parse(string letter)
    {
        switch (letter)
        {
            case "X":
                return X;
            case "Y":
                return Y;
            case "Z":
                return Z;
        }

        throw new ArgumentException();
    }
}