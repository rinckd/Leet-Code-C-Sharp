using LeetCode._0001_0050;
using Xunit;

namespace LeetCode.Test._0001_0050;

public class _001_Two_Sum_Test
{
    
    [Fact]
    public void TwoSumTest_Ordered()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var result = _001_Two_Sum.TwoSum(nums, 9);

        Assert.Equal(2, result.Length);
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }
    
    [Fact]
    public void TwoSumTest_Unordered()
    {
        var nums = new[] { 5, 75, 25 };
        var result = _001_Two_Sum.TwoSum(nums, 100);

        Assert.Equal(2, result.Length);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
    }
    
}