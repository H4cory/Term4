//namespace _02._03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestGetCurrentPlayer()
    {
        Game game = new Game();

        int expectedP = 1;
        int actual = game.getCurPlayer();

        Assert.AreEqual(expectedP, actual);
    }
}