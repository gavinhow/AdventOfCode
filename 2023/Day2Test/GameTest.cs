using Day2;

namespace Day2Test;

public class GameTest
{
  [Fact]
  public void SetConstructorTest()
  {
    var set = new Set("3 blue, 4 red");
    Assert.Equal(4, set.cubes["red"]);
    Assert.Equal(3, set.cubes["blue"]);
  }
  
  [Fact]
  public void GameConstructorTest()
  {
    var game = new Game("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
    Assert.Equal(1, game.Id);
    Assert.Equal(3, game.Sets.ToList()[0].cubes["blue"]);
    Assert.Equal(2, game.Sets.ToList()[1].cubes["green"]);
  }
  
  [Fact]
  public void ValidateTest()
  {
    var set = new Set("3 blue, 4 red");
    Assert.False(set.Validate("2 blue, 3 red"));
    Assert.True(set.Validate("4 blue, 4 red"));
    Assert.False(set.Validate("4 green"));
  }
  
  [Fact]
  public void GameValidateTest()
  {
    var game = new Game("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
    Assert.True(game.Validate("22 blue, 32 red"));
    Assert.False(game.Validate("1 blue, 1 red"));
  }

  [Fact]
  public void TestGamePower()
  {
    var game = new Game("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
    Assert.Equal(48, game.Power);
  }
  
  [Fact]
  public void TestGamePower2()
  {
    var game = new Game("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue");
    Assert.Equal(12, game.Power);
  }
}