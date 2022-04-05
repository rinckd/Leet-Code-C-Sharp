using LeetCode.LeetHelpers;
using Xunit;

namespace LeetCode.Test.TestHelpers;

public static class AssertHelper
{
    public static void AssertLinkList(int[] expected, ListNode? actual)
    {
        Assert.NotNull(actual);
        Assert.NotNull(expected);
        Assert.True(expected.Length > 0);

        var current = actual;
        foreach (var t in expected)
        {
            Assert.NotNull(current);
            Assert.Equal(t, current?.val);
            current = current?.next;
        }

        Assert.Null(current);
    }
}