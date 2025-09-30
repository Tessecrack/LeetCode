public class Solution {
    public string LongestPalindrome(string s)
    {
        // BAD SOLUTION
        var result = string.Empty;
        for (int i = 0; i < s.Length; ++i)
        {
            for (int j = i; j < s.Length; ++j)
            {
                if (IsPalindrome(s, i, j - i + 1))
                {
                    var strBuf = s.Substring(i, j - i + 1);
                    if (strBuf.Length > result.Length)
                    {
                        result = strBuf;
                    }
                }
            }
        }
        return result;
    }

    private bool IsPalindrome(string s, int start, int length)
    {
        for (int i = 0; i < length / 2; ++i)
        {
            char beginChar = s[i + start];
            char endChar = s[start + length - i - 1];
            if (beginChar != endChar)
            {
                return false;
            }
        }

        return true;
    }
}