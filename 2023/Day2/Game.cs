namespace Day2;

public class Game
{
  public int Id { get; private set; }
  
  public IEnumerable<Set> Sets  { get; private set; }

  public int Power
  {
    get
    {
      Dictionary<string, int> mininumBag = new Dictionary<string, int>();
      foreach (var set in Sets)
      {
        foreach (var cube in set.cubes)
        {
          if (!mininumBag.ContainsKey(cube.Key) || mininumBag[cube.Key] < cube.Value)
          {
            mininumBag[cube.Key] = cube.Value;
          }
        }
      }

      return mininumBag.Aggregate(1, (current, cube) => current * cube.Value);
    }
  }

  public Game(int id, List<Set> sets)
  {
    Id = id;
    Sets = sets;
  }
  
  public Game(string input)
  {
    Id = int.Parse(input.Split(':')[0].Replace("Game ", ""));
    Sets = input.Split(':')[1].Split(";").Select(x => new Set(x));
  }
  
  public bool Validate(string input)
  {
    return Sets.All(set => set.Validate(input));
  }
}

public class Set
{
  public Set(string input)
  {
    cubes = new Dictionary<string, int>();
    input.Split(",")
      .Select(x => x.Trim())
      .ToList()
      .ForEach(x => cubes.Add(x.Split(" ")[1], int.Parse(x.Split(" ")[0])));
  }
  public Dictionary<string, int> cubes { get; private set; }
  
  public bool Validate(string input)
  {
    Dictionary<string, int> bagDefinition = new Dictionary<string, int>();
    input.Split(",")
      .Select(x => x.Trim())
      .ToList()
      .ForEach(x => bagDefinition.Add(x.Split(" ")[1], int.Parse(x.Split(" ")[0])));

    foreach (KeyValuePair<string, int> cube in cubes)
    {
      if (!bagDefinition.ContainsKey(cube.Key) || bagDefinition[cube.Key] < cube.Value) return false;
    }

    return true;
  }
}