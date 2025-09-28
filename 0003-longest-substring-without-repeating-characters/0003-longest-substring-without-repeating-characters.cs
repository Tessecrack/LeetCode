public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        return GetMaxSubStr(s);
    }

    private int GetMaxSubStr(string s)
    {
        var chars = new Dictionary<char, int>();
        int maxCounter = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            var ch = s[i];

            if (chars.TryGetValue(ch, out var index))
            {
                if (chars.Count > maxCounter)
                {
                    maxCounter = chars.Count;
                }
                chars = chars.SkipWhile(x => x.Value <= index).ToDictionary();
            }
            chars[ch] = i;
        }

        return chars.Count > maxCounter ? chars.Count : maxCounter;
    }
}