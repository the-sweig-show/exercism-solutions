public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lowerWord = word.ToLower();
        HashSet<char> seenLetters = new HashSet<char>();

        foreach (char c in lowerWord)
        {
            if (c == ' ' || c == '-' || c  == '_')
            {
                continue;
            }
            if (seenLetters.Contains(c))
            {
                return false;
            }
            seenLetters.Add(c);
        }
        return true;
    }
}
