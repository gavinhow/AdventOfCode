namespace Day2
{
    public class PasswordEntry
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public char SearchChar { get; set; }
        public string Password { get; set; }
        
        public static PasswordEntry Parse(string input)
        {
            string[] components = input.Split(' ');
            
            string[] firstEntry = components[0].Split('-');
            int minimum = int.Parse(firstEntry[0]);
            int maximum = int.Parse(firstEntry[1]);
            
            char searchChar = char.Parse(components[1].TrimEnd(':'));

            string password = components[2];
            
            return new PasswordEntry() { Minimum = minimum, Maximum = maximum, SearchChar = searchChar, Password = password};
        }
    }
}