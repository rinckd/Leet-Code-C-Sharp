namespace LeetCode.LeetHelpers;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x) { val = x; }
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class TestHelper
{
    public static ListNode? GenerateList(int[]? nums)
    {
        if (nums == null || nums.Length == 0) { return null; }

        var i = 0;
        var first = new ListNode(nums[i]);
        var current = first;

        while (++i < nums.Length)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;
        }

        return first;
    }
 
}