namespace LeetCode._0001_0050;

public static class _003_Longest_Substring_Without_Repeating {
    public static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        var map = new Dictionary<int, int>();
        var maxLen = 0;
        var lastRepeatPos = -1;
        for (var i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]) && lastRepeatPos < map[s[i]])
            {
                lastRepeatPos = map[s[i]];
            }
            if (maxLen < i - lastRepeatPos)
            {
                maxLen = i - lastRepeatPos;
            }

            map[s[i]] = i;
        }

        return maxLen;
    }
}
 