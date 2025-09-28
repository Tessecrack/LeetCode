public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        return GetMaxSubStr(s);
    }

    private int GetMaxSubStr(string s)
    {

        var charsIndexes = new Dictionary<char, int>();
        int maxCounter = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            var ch = s[i];
            if (charsIndexes.TryGetValue(ch, out var index))
            {
                if (charsIndexes.Count > maxCounter)
                {
                    maxCounter = charsIndexes.Count;
                }
                charsIndexes.Clear();
                i = index;
            }
            else
            {
                charsIndexes[ch] = i;
            }
        }

        return charsIndexes.Count > maxCounter ? charsIndexes.Count : maxCounter;
    }
}