namespace LeetCode._0001_0050;

public static class _001_Two_Sum {
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                return new[] { dict[nums[i]], i };
            }

            dict[target - nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}