public static class VentanaDeslizante
{
    // Longest Substring Without Repeating Characteres

    public static int LongestSubStringWithoutRepeat(string text)
    {
        var hash = new HashSet<char>();
        int count = 0;
        int max = 0;
        int p = 0;

        while (text.Length > p)
        {
            if (!hash.Contains(text[p]))
            {
                hash.Add(text[p]);
                count++;
                p++;
            }
            else
            {
                if (count > max) max = count;
                hash.Clear();
                count = 0;
            }
        }
        if (count > max) max = count;
        return max;
    }
}