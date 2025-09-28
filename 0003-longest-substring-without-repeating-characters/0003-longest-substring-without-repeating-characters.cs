public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        return GetMaxSubStr(s);
    }

    private int GetMaxSubStr(string s)
    {
        var charsIndexes = new Dictionary<char, int>();
        int left = 0;
        int maxCounter = 0;
        for (int right = 0; right < s.Length; ++right)
        {
            char current = s[right];
            if (charsIndexes.TryGetValue(current, out int value) && value >= left)
            {
                left = value + 1;
            }

            charsIndexes[current] = right;
            maxCounter = Math.Max(maxCounter, right - left + 1);
        }

        return maxCounter;
    }
}