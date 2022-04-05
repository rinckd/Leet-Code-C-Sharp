using LeetCode.LeetHelpers;

namespace LeetCode._0001_0050;

public static class _002_Add_Two_Numbers {
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var solution = new ListNode(-1);
        var current = solution;
        var carry = 0;
        while (l1 != null || l2 != null)
        {
            var value1 = l1?.val ?? 0;
            var value2 = l2?.val ?? 0;
            var sum = value1 + value2 + carry;
            carry = sum / 10;
            sum %= 10;
            current.next = new ListNode(sum);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (carry != 0)
        {
            current.next = new ListNode(carry);
        }

        return solution.next;
    }
}