namespace Day2;

public class Logic
{
    public static int CalculateTotalScore(string input)
    {
        string[] lines = input.Split('\n');
        Round[] rounds = lines.Select(Round.parse).ToArray();
        int total = rounds.Sum(round => round.MyRoundScore);
        return total;
    }
}