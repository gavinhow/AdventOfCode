namespace Day2;

public class Logic
{
  public static int SumValidGames(string[] lines, string testCubes)
  {
    IEnumerable<Game> games = lines.Select(x => new Game(x));
    return games.Where(game => game.Validate(testCubes)).Sum(x => x.Id);
  } 
  
  public static int SumPowerGames(string[] lines)
  {
    IEnumerable<Game> games = lines.Select(x => new Game(x));
    return games.Sum(game => game.Power);
  } 
}