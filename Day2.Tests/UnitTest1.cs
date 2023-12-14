namespace Day2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(typeof(GameData), nameof(GameData.GameTestData))]
        public void TestGames(string game, int gameId, bool expectedResult)
        {
            var actualResult = GameManager.CheckGameResults(game);
            Assert.That(actualResult.gamePassed, Is.EqualTo(expectedResult));
            Assert.That(actualResult.gameId, Is.EqualTo(gameId));

        }
        [Test]
        [TestCaseSource(typeof(GameData), nameof(GameData.TotalTestCases))]
        public void TestTotal(List<string> games, int expectedResult)
        {
            var actualResult = GameManager.GetTotalIds(games);
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
    }
}