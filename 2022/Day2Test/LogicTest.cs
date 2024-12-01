using Day2;

namespace Day2Test;

public class LogicTest
{
    [Fact]
    public void RoundScore()
    {
        Round round = new Round(MyPlay.Y, OpponentPlay.A);
        Assert.Equal(8, round.MyRoundScore);
    }
    
    [Fact]
    public void RoundScore2()
    {
        Round round = new Round(MyPlay.X, OpponentPlay.B);
        Assert.Equal(1, round.MyRoundScore);
    }
    
    [Fact]
    public void RoundScore3()
    {
        Round round = new Round(MyPlay.Z, OpponentPlay.C);
        Assert.Equal(6, round.MyRoundScore);
    }

    [Fact]
    public void RoundParse()
    {
        Round round = Round.parse("A Y");
        Assert.Equal(RockPaperScissors.Rock, round.OpponentPlay.RockPaperScissors);
        Assert.Equal(RockPaperScissors.Paper, round.MyPlay.RockPaperScissors);
    }
    
    [Theory]
    [InlineData("A X", 4)]
    [InlineData("A Y", 8)]
    [InlineData("A Z", 3)]
    [InlineData("B X", 1)]
    [InlineData("B Y", 5)]
    [InlineData("B Z", 9)]
    [InlineData("C X", 7)]
    [InlineData("C Y", 2)]
    [InlineData("C Z", 6)]
    public void RoundParseAndScore(string input, int expectedScore)
    {
        Round round = Round.parse(input);
        Assert.Equal(expectedScore, round.MyRoundScore);

    }
    
    [Fact]
    public void CalculateTotalScore()
    {
        string input = @"A Y
B X
C Z";
        Assert.Equal(15, Logic.CalculateTotalScore(input));
    }
}