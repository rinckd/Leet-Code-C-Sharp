using LeetCode._0001_0050;
using LeetCode.LeetHelpers;
using LeetCode.Test.TestHelpers;
using Xunit;

namespace LeetCode.Test._0001_0050;

public class _002_Add_Two_Numbers_Test {
    [Fact]
    public void AddTwoNumbersTest_General()
    {
        var link = TestHelper.GenerateList(new[] { 2, 4, 3 });
        var result = _002_Add_Two_Numbers.AddTwoNumbers(link, link);

        AssertHelper.AssertLinkList(new[] { 4, 8, 6 }, result);
    }
    
    [Fact]
    public void AddTwoNumbersTest_General2()
    {
        var link = TestHelper.GenerateList(new[] { 2, 4, 3 });
        var link2 = TestHelper.GenerateList(new[] { 5, 6, 4 });
        var result = _002_Add_Two_Numbers.AddTwoNumbers(link, link2);

        AssertHelper.AssertLinkList(new[] { 7, 0, 8 }, result);
    }
}