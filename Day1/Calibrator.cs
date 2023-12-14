using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1
{
    public static class Calibrator
    {
        public static int GetTotalCalibrationNumber(List<string> inputs, bool isPart2)
        {
            int total = 0;
            foreach (string input in inputs)
            {
                if (isPart2)
                {
                    total += GetCalibrationNumber2(input);
                }
                else
                {
                    total += GetCalibrationNumber(input);
                }
            }
            return total;
        }

        public static int GetCalibrationNumber(string line)
        {
            int returnValue = SetCalibartionValue(line);
            return returnValue;
        }
        public static int GetCalibrationNumber2(string line)
        {
            line = ReplaceNumbersWithWords(line);
            line = GetMatches(line);
            int returnValue = SetCalibartionValue(line);
            return returnValue;
        }

        private static int SetCalibartionValue(string line)
        {
            int returnValue = 0;
            Regex regex = new Regex(@"\d+");
            var matches = regex.Matches(line);
            var numbersLeft = ParseMatches(matches);
            if (numbersLeft.Count == 2)
            {
                returnValue = int.Parse(string.Join("", numbersLeft));
            }

            if (numbersLeft.Count == 1)
            {
                returnValue = int.Parse(string.Join("", numbersLeft[0], numbersLeft[0]));
            }

            if (numbersLeft.Count > 2)
            {
                returnValue = int.Parse(string.Join("", numbersLeft[0], numbersLeft[numbersLeft.Count - 1]));
            }

            if (returnValue < 10)
                Console.WriteLine(line);

            return returnValue;
        }


        private static string ReplaceNumbersWithWords(string line)
        {
            line = line
                .Replace("1", "one")
                .Replace("2", "two")
                .Replace("3", "three")
                .Replace("4", "four")
                .Replace("5", "five")
                .Replace("6", "six")
                .Replace("7", "seven")
                .Replace("8", "eight")
                .Replace("9", "nine");
            return line;
        }

        private static string GetMatches(string line)
        {
            List<string> wordDigits = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };

            var foundWords = wordDigits.SelectMany(x =>           
                Regex.Matches(line, x, RegexOptions.IgnoreCase)
                .Cast<Match>()
                .Select(m => new { Value = m.Value, Index = m.Index })  
            ).OrderBy(x => x.Index)
             .ToList();

            var value1 = ParseFoundValues(foundWords[0].Value);
            if (foundWords.Count > 1)
            {
                var value2 = ParseFoundValues(foundWords[foundWords.Count - 1].Value);

                return value1 + value2;
            }
            else
            {
                return value1 + value1;
            }
        }

        private static string ParseFoundValues(string value)
        {
            value = value
               .Replace("one", "1")
               .Replace("two", "2")
               .Replace("three", "3")
               .Replace("four", "4")
               .Replace("five", "5")
               .Replace("six", "6")
               .Replace("seven", "7")
               .Replace("eight", "8")
               .Replace("nine", "9");
            return value;
        }

        private static List<int> ParseMatches(MatchCollection matches)
        {
            var list = new List<int>();
            foreach (Match match in matches)
            {
                foreach(var item in match.Value.ToArray())
                {
                    list.Add(int.Parse(item.ToString()));
                }
            }
            return list;
        }
    }
}
