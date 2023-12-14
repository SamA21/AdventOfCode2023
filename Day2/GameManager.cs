using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    public static class GameManager
    {
        private static int MaxRed = 12;
        private static int MaxGreen = 13;
        private static int MaxBlue = 14;

        public static int GetTotalIds(List<string> inputs)
        {
            var result = 0;
            foreach (var input in inputs)
            {
                var gameResult = CheckGameResults(input);
                if(gameResult.gamePassed)
                    result += gameResult.gameId;
            }
            return result;
        }

        public static (int gameId, bool gamePassed) CheckGameResults(string input)
        {
            bool gameResult = true;
            var splits = input.Split(':');
            Regex regex = new Regex(@"\d+");
            var matches = regex.Matches(splits[0]);
            var gameId = int.Parse(matches.First().Value);

            var games = splits[1].Split(';');
            foreach (var game in games)
            {
                var blueTotal = 0;
                var redTotal = 0;
                var greenTotal = 0;
                var balls = game.Trim().Split(", ");
                foreach(var ballColour in balls)
                {
                    var ballSplit = ballColour.Split(" ");
                    switch (ballSplit[1])
                    {
                        case "blue":
                            blueTotal += int.Parse(ballSplit[0]);
                            break;
                        case "red":
                            redTotal += int.Parse(ballSplit[0]);
                            break;
                        case "green":
                            greenTotal += int.Parse(ballSplit[0]);
                            break;
                        default:
                            throw new Exception("Error invalid ball colour");
                    };
                }

                if (blueTotal > MaxBlue
                    || redTotal > MaxRed
                    || greenTotal > MaxGreen)
                {
                    gameResult = false;
                }

            }


            return (gameId, gameResult);
        }
    }
}

