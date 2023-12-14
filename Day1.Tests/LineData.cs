using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Tests
{
    public class LineData
    {
        public static IEnumerable LineTestCases
        {
            get
            {
                yield return new object[] { "1abc2", 12 };
                yield return new object[] { "pqr3stu8vwx", 38 };
                yield return new object[] { "a1b2c3d4e5f", 15 };
                yield return new object[] { "treb7uchet", 77 };
            }
        }

        public static IEnumerable WordLineTestCases
        {
            get
            {
                yield return new object[] { "two1nine", 29 };
                yield return new object[] { "eightwothree", 83 };
                yield return new object[] { "abcone2threexyz", 13 };
                yield return new object[] { "xtwone3four", 24 };
                yield return new object[] { "4nineeightseven2", 42 };
                yield return new object[] { "zoneight234", 14 };
                yield return new object[] { "7pqrstsixteen", 76 };
            }
        }

        public static IEnumerable TotalTestCases
        {
            get
            {
                List<string> totalList = new List<string>();
                totalList.Add("1abc2");
                totalList.Add("pqr3stu8vwx");
                totalList.Add("a1b2c3d4e5f");
                totalList.Add("treb7uchet");
                yield return new object[] { totalList, 142, false };
                List<string> totalList2 = new List<string>();
                totalList2.Add("two1nine");
                totalList2.Add("abcone2threexyz");
                totalList2.Add("eightwothree");
                totalList2.Add("xtwone3four");
                totalList2.Add("4nineeightseven2");
                totalList2.Add("zoneight234");
                totalList2.Add("7pqrstsixteen");
                yield return new object[] { totalList2, 281, true };

            }
        }
    }
}
