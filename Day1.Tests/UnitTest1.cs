using System.Collections;

namespace Day1.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(typeof(LineData), nameof(LineData.LineTestCases))]
        public void TestLines(string line, int expectedResult)
        {
            var actualResult = Calibrator.GetCalibrationNumber(line);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        [TestCaseSource(typeof(LineData), nameof(LineData.WordLineTestCases))]
        public void TestWordLines(string line, int expectedResult)
        {
            var actualResult = Calibrator.GetCalibrationNumber2(line);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        [TestCaseSource(typeof(LineData), nameof(LineData.TotalTestCases))]
        public void TestTotal(List<string> list, int expectedResult, bool part2)
        {
            var actualResult = Calibrator.GetTotalCalibrationNumber(list, part2);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}