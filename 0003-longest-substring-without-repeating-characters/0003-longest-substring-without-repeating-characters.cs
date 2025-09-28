public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        return GetMaxSubStr(s);
    }

    private int GetMaxSubStr(string s)
    {
        var chars = new List<char>();
        int maxCounter = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            var ch = s[i];
            if (chars.Contains(ch))
            {
                if (chars.Count > maxCounter)
                {
                    maxCounter = chars.Count;
                }
                chars.RemoveAt(0);
                i--;
                continue;
            }
            chars.Add(ch);
        }

        return chars.Count > maxCounter ? chars.Count : maxCounter;
    }
}