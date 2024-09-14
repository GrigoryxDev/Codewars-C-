using NUnit.Framework;

public class PathFinderOneShortestPathTests
{
    [Test]
    public void sampleTests()
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

        Assert.AreEqual(true, PathFinderOneCanYouReachTheExit.PathFinder(a));
        Assert.AreEqual(false, PathFinderOneCanYouReachTheExit.PathFinder(b));
        Assert.AreEqual(true, PathFinderOneCanYouReachTheExit.PathFinder(c));
        Assert.AreEqual(false, PathFinderOneCanYouReachTheExit.PathFinder(d));
    }
}