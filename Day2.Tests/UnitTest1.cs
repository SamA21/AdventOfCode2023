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
        [TestCaseSource(typeof(GameData), nameof(GameData.GameTestDataPart2))]
        public void TestGames(string game, int redCubes, int blueCubes, int greenCubes)
        {
            var actualResult = GameManager.GetMaxValue(game);
            Assert.That(actualResult.red, Is.EqualTo(redCubes));
            Assert.That(actualResult.blue, Is.EqualTo(blueCubes));
            Assert.That(actualResult.green, Is.EqualTo(greenCubes));

        }

        [Test]
        [TestCaseSource(typeof(GameData), nameof(GameData.TotalTestCases))]
        public void TestTotal(List<string> games, int expectedResult, bool isPart2)
        {
            if (!isPart2)
            {
                var actualResult = GameManager.GetTotalIds(games);
                Assert.That(actualResult, Is.EqualTo(expectedResult));
            }
            else 
            {
                var actualResult = GameManager.GetTotalPower(games);
                Assert.That(actualResult, Is.EqualTo(expectedResult));
            }

        }
    }
}