namespace Day2;

public class Round
{
    public MyPlay MyPlay;

    public OpponentPlay OpponentPlay;

    public Round(MyPlay myPlay, OpponentPlay opponentPlay)
    {
        this.MyPlay = myPlay;
        this.OpponentPlay = opponentPlay;
    }

    public int MyRoundScore
    {
        get
        {
            int roundScore;
            switch (this.MyPlay.CompareTo(this.OpponentPlay))
            {
                case < 0:
                    roundScore = 0;
                    break;
                case 0:
                    roundScore = 3;
                    break;
                case > 0:
                    roundScore = 6;
                    break;
            }

            roundScore += (int)this.MyPlay.RockPaperScissors;


            return roundScore;
        }
    }

    public static Round parse(string input)
    {
        string[] values = input.Split(' ');
        return new Round(MyPlay.parse(values[1]), OpponentPlay.parse(values[0]));
    }
}