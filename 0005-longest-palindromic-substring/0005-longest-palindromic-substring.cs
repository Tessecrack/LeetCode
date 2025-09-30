public class Solution {
    public string LongestPalindrome(string s)
    {
        // BAD SOLUTION
        var result = string.Empty;
        for (int i = 0; i < s.Length; ++i)
        {
            for (int j = i; j < s.Length; ++j)
            {
                var strBuf = s.Substring(i, j - i + 1);
                if (IsPalindrome(strBuf) && strBuf.Length > result.Length)
                {
                    result = strBuf;
                }
            }
        }
        return result;
    }

    private bool IsPalindrome(string s)
    {
        for (int i = 0; i < s.Length / 2; ++i)
        {
            var beginIndex = i;
            var endIndex = s.Length - i - 1;
            if (s[beginIndex] != s[endIndex])
            {
                return false;
            }
        }
        return true;
    }
}