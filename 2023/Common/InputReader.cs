namespace Common;

public static class InputReader
{
  public static Task<string> ReadText()
  {
    return System.IO.File.ReadAllTextAsync(@"input.txt");
    
  }

  public static Task<string[]> ReadLines()
  {
    return File.ReadAllLinesAsync("input.txt");
  }
}