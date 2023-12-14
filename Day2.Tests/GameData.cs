using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Tests
{
    public class GameData
    {
        public static IEnumerable GameTestData
        {
            get
            {
                yield return new object[] { "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 1, true };
                yield return new object[] { "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 2, true };
                yield return new object[] { "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3, false };
                yield return new object[] { "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 4, false };
                yield return new object[] { "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 5, true };
            }
        }

        public static IEnumerable TotalTestCases
        {
            get
            {
                List<string> totalList = new List<string>();
                totalList.Add("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green");
                totalList.Add("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue");
                totalList.Add("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red");
                totalList.Add("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red");
                totalList.Add("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green");
                yield return new object[] { totalList, 8 };

            }
        }
    }
}
