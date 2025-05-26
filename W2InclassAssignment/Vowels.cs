namespace W2InClassAssignment;

public class Vowels
{
    public static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiou";

        foreach (char c in input.ToLower())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}