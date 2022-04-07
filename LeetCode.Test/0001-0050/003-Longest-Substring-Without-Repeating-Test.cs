using LeetCode._0001_0050;
using Xunit;

namespace LeetCode.Test._0001_0050;

public class _003_Longest_Substring_Without_Repeating_Test {
    [Fact]
    public void LengthOfLongestSubstringTest()
    {
        const string input = "abcabcbb";
        var result = _003_Longest_Substring_Without_Repeating.LengthOfLongestSubstring(input);
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void LengthOfLongestSubstringTest2()
    {
        const string input = "bbbbb";
        var result = _003_Longest_Substring_Without_Repeating.LengthOfLongestSubstring(input);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void LengthOfLongestSubstringTest3()
    {
        const string input = "";
        var result = _003_Longest_Substring_Without_Repeating.LengthOfLongestSubstring(input);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void LengthOfLongestSubstringTest4()
    {
        const string input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        var result = _003_Longest_Substring_Without_Repeating.LengthOfLongestSubstring(input);
        Assert.Equal(26, result);
    }
}