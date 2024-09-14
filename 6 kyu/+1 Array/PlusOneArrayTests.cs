using NUnit.Framework;

[TestFixture]
public class PlusOneArrayTests
{
    [Test]
    public void Test1()
    {
        var num = new int[] { 2, 3, 9 };
        var newNum = new int[] { 2, 4, 0 };
        Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
    }

    [Test]
    public void Test2()
    {
        var num = new int[] { 4, 3, 2, 5 };
        var newNum = new int[] { 4, 3, 2, 6 };
        Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
    }

    [Test]
    public void Test3()
    {
        var num = new int[] { 0, 4, 2 };
        var newNum = new int[] { 0, 4, 3 };
        Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
    }

    [Test]
    public void Test4()
    {
        var num = new int[] { 9, 9 };
        var newNum = new int[] { 1, 0, 0 };
        Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
    }

    [Test]
    public void UpBigArray()
    {
        var num = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1 };
        var newNum = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
        Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
    }
}