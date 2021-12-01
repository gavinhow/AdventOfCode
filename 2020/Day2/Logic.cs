namespace Day2
{
    public class Logic
    {
        public static bool PasswordValidCheck(in int minimum, in int maximum, in char letter, string password)
        {
            int occurences = password.Split(letter).Length - 1;
            return minimum <= occurences && occurences <= maximum;
        }
        
        public static bool PasswordValidCheckPart2(in int firstIndex, in int secondIndex, in char letter, string password)
        {
            bool firstIndexResult = password[firstIndex - 1] == letter;
            
            bool secondIndexResult;
            if (secondIndex > password.Length)
                secondIndexResult = false;
            else
                secondIndexResult = password[secondIndex - 1] == letter;

            return firstIndexResult != secondIndexResult;
        }
    }
}