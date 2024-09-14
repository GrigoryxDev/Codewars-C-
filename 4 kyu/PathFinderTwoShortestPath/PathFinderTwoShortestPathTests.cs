using NUnit.Framework;

public class PathFinderTwoShortestPathTests
{
    [Test]
    public void TestBasic()
    {

        string a = ".W.\n" +
                   ".W.\n" +
                   "...",

               b = ".W.\n" +
                   ".W.\n" +
                   "W..",

               c = "......\n" +
                   "......\n" +
                   "......\n" +
                   "......\n" +
                   "......\n" +
                   "......",

               d = "......\n" +
                   "......\n" +
                   "......\n" +
                   "......\n" +
                   ".....W\n" +
                   "....W.";

        Assert.AreEqual(4, PathFinderTwoShortestPath.PathFinder(a));
        Assert.AreEqual(-1, PathFinderTwoShortestPath.PathFinder(b));
        Assert.AreEqual(10, PathFinderTwoShortestPath.PathFinder(c));
        Assert.AreEqual(-1, PathFinderTwoShortestPath.PathFinder(d));
    }
}

